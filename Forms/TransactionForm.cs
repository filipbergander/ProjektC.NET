using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Projekt.Services;
using Projekt.Models;
using Projekt.Forms;

namespace Projekt.Forms
{
    public partial class TransactionForm : Form

    {
        private readonly MainForm mainForm; // Instans av mainform
        private string currentSortColumn = ""; // Vilken kolumn som är sorterad i datagriden
        private bool ascending = true; // Sorteringsordningen för kolumnerna i datagriden
        private readonly TransactionService transaction;   // Instans av TransactionService

        private List<Transaction> transactions = new List<Transaction>();
        // Konstruktor som tar emot en instans av TransactionService (transaction) och sätter den till _transaction
        public TransactionForm(TransactionService transaction, MainForm mainForm)
        {
            InitializeComponent();
            this.transaction = transaction;
            this.mainForm = mainForm;
            LoadTransactions(); // Hämtar in alla sparade transaktioner
        }
        // Hämtar in transaktioner sparade i databasen och visar i datagriden (listan av transaktioner)
        private async void LoadTransactions()
        {
            transactions = await transaction.GetTransactions();
            transactionGrid.DataSource = null;
            transactionGrid.DataSource = transactions;
            totalTransactionsPostLabel.Text = $"Visar {transactions.Count} transaktioner";

        }
        // Sorterar kolumnerna i datagriden när man klickar på kolumnrubriken, och lägger till en pil som visar sorteringsordningen (fallande/stigande)
        private async void transactionGrid_ColumnHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Hämtar den klickade kolumnen och dess namn
            var clickedColumn = transactionGrid.Columns[e.ColumnIndex];
            string columnName = clickedColumn.DataPropertyName;

            // Om kolumnnamnet är tomt, return
            if (string.IsNullOrEmpty(columnName))
                return;

            // Vänder på sorteringsordningen om samma kolumn klickas igen
            if (currentSortColumn == columnName)
            {
                ascending = !ascending;
            }
            else
            {
                ascending = true;
                currentSortColumn = columnName;
            }
            // Hämtar in de sorterade transaktionerna och visar dem i datagriden
            var sortedTransactions = await transaction.GetSortedTransactions(columnName, ascending);
            transactionGrid.DataSource = null;
            transactionGrid.DataSource = sortedTransactions;

            //Återställer kolumnrubrikerna till sitt ordinarie namn varje gång vid klick, annars läggs text till på text
            foreach (DataGridViewColumn column in transactionGrid.Columns)
            {
                if (!string.IsNullOrEmpty(column.DataPropertyName))
                {
                    column.HeaderText = column.DataPropertyName switch
                    {
                        nameof(Transaction.Id) => "Id",
                        nameof(Transaction.Typ) => "Typ",
                        nameof(Transaction.Namn) => "Namn",
                        nameof(Transaction.Kategori) => "Kategori",
                        nameof(Transaction.Belopp) => "Belopp",
                        nameof(Transaction.Datum) => "Datum",
                        _ => column.DataPropertyName
                    };
                }
            }
            // Lägger till pilen som visar sorteringsordningen (fallande/stigande) på den klickade kolumnen
            var refreshedColumn = transactionGrid.Columns[e.ColumnIndex];
            refreshedColumn.HeaderText += ascending ? " ▲" : " ▼";
        }

        // Ändrar muspekaren på datagridens kolumnrubriker vid hover
        private void transactionGrid_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex >= 0) // Hover på de faktiska kolumnrubrikerna (inte på celler)
            {
                transactionGrid.Cursor = Cursors.Hand; // Muspekaren -> hand
            }
            else
            {
                transactionGrid.Cursor = Cursors.Default; // Muspekaren -> standard
            }
        }

        // Går tillbaka till Mainform vid klick -> "Gå tillbaka" knapp
        private void transactionFormReturnBtn_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Close();
        }
        // Öppnar formuläret för att lägga till en ny transaktion vid klick -> "Lägg till"
        private void AddNewTransactionBtn_Click(object sender, EventArgs e)
        {
            var addTransactionForm = new AddTransactionForm(transaction);
            addTransactionForm.FormClosed += (s, args) =>
            {
                this.Show(); // Laddar om transaktionerna när formuläret stängs
                LoadTransactions();
            };
            addTransactionForm.Show();
            this.Hide();
        }
        // Stänger formuläret vid klick -> "Stäng" (X-knappen i windows)
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Formaterar cellerna i datagriden för att visa "belopp" med röd/grön färg och +- beroende på om det är en utgift eller inkomst
        private void transactionGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Varje transaktionsrad i datagriden
            var transaction = transactionGrid.Rows[e.RowIndex].DataBoundItem as Transaction;

            // Om det inte är Belopp-kolumnen gör metoden inget..
            if (e.RowIndex < 0 || transactionGrid.Columns[e.ColumnIndex].DataPropertyName != "Belopp")
                return;

            // Ändrar beloppets färg samt +- beroende på om transaktionen är utgift/inkomst
            if (transaction.Typ == "Utgift")
            {
                e.Value = $"-{transaction.Belopp:N2} kr"; 
                e.CellStyle.ForeColor = Color.Firebrick;
            }
            else
            {
                e.Value = $"+{transaction.Belopp:N2} kr";
                e.CellStyle.ForeColor = Color.SeaGreen;
            }
            // Formateringen har gjorts
            e.FormattingApplied = true;
        }
    }
}
