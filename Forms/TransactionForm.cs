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
        // Instans av TransactionService (_transaction)
        private readonly TransactionService _transaction;
        // Konstruktor som tar emot en instans av TransactionService (transaction) och sätter den till _transaction
        public TransactionForm(TransactionService transaction)
        {
            InitializeComponent();
            _transaction = transaction;
            LoadTransactions(); // Hämtar in alla sparade transaktioner
        }
        // Hämtar in transaktioner sparade i databasen och visar datagriden (listan av transaktioner)
        private async void LoadTransactions()
        {
            var transactions = await _transaction.GetTransactions();
            transactionGrid.DataSource = null;
            transactionGrid.DataSource = transactions;
        }

        private void TransactionForm_Load(object sender, EventArgs e)
        {

        }
        // Går tillbaka till Mainform vid klick -> "Gå tillbaka" knapp
        private void transactionFormReturnBtn_Click(object sender, EventArgs e)
        {
            var mainForm = new MainForm();
            mainForm.Show();
            this.BeginInvoke(new Action(() => this.Close()));
        }
        // Öppnar formuläret för att lägga till en ny transaktion vid klick -> "Lägg till" knapp
        private void addNewTransactionBtn_Click(object sender, EventArgs e)
        {
            var addTransactionForm = new AddTransactionForm(_transaction);
            addTransactionForm.Show();
            this.BeginInvoke(new Action(() => this.Close()));
        }
    }
}
