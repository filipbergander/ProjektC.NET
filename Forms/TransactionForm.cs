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

        private readonly TransactionService _transaction;
        public TransactionForm(TransactionService transaction)
        {
            InitializeComponent();
            _transaction = transaction;
            LoadTransactions();
        }

        private void LoadTransactions()
        {
            transactionGrid.DataSource = null;
            transactionGrid.DataSource = _transaction.GetTransactions();
        }

        private void TransactionForm_Load(object sender, EventArgs e)
        {

        }

        private void transactionFormReturnBtn_Click(object sender, EventArgs e)
        {
            var mainForm = new MainForm();
            mainForm.Show();
            this.BeginInvoke(new Action(() => this.Hide()));
        }

        private void addNewTransactionBtn_Click(object sender, EventArgs e)
        {
            var addTransactionForm = new AddTransactionForm(_transaction);
            addTransactionForm.Show();
            this.BeginInvoke(new Action(() => this.Hide()));
        }
    }
}
