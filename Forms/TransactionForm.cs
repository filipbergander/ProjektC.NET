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
        private readonly MainForm mainForm;

        // Instans av TransactionService
        private readonly TransactionService _transaction;
        // Konstruktor som tar emot en instans av TransactionService (transaction) och sätter den till _transaction
        public TransactionForm(TransactionService transaction, MainForm mainForm)
        {
            InitializeComponent();
            _transaction = transaction;
            this.mainForm = mainForm;
            LoadTransactions(); // Hämtar in alla sparade transaktioner
        }
        // Hämtar in transaktioner sparade i databasen och visar datagriden (listan av transaktioner)
        private async void LoadTransactions()
        {
            var transactions = await _transaction.GetTransactions();
            transactionGrid.DataSource = null;
            transactionGrid.DataSource = transactions;
        }

        private async void transactionGrid_ColumnHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            string columnName = transactionGrid.Columns[e.ColumnIndex].DataPropertyName;
            var transactions = await _transaction.GetTransactionsSorted(columnName);
            transactionGrid.DataSource = transactions;

        }

        // Går tillbaka till Mainform vid klick -> "Gå tillbaka" knapp
        private void transactionFormReturnBtn_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Close();
        }
        // Öppnar formuläret för att lägga till en ny transaktion vid klick -> "Lägg till" knapp
        private void AddNewTransactionBtn_Click(object sender, EventArgs e)
        {
            var addTransactionForm = new AddTransactionForm(_transaction);
            addTransactionForm.FormClosed += (s, args) =>
            {
                this.Show(); // Laddar om transaktionerna när formuläret stängs
                LoadTransactions();
            };
            addTransactionForm.Show();
            this.Hide();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
