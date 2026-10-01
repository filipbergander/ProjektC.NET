using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Services;
using Models;
using ProjektC_.NET.Forms;

namespace Forms
{
    public partial class TransactionForm : Form
    {

        private readonly TransactionService newTransaction;
        public TransactionForm(TransactionService transaction)
        {
            InitializeComponent();
            newTransaction = transaction;
            LoadTransactions();
        }

        private void LoadTransactions()
        {
            transactionGrid.DataSource = null;
            transactionGrid.DataSource = newTransaction.GetTransactions();
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
    }
}
