using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Projekt.Models;
using Projekt.Services;
using Projekt.Forms;

namespace Projekt.Forms
{
    public partial class    MainForm : Form
    {
        private readonly TransactionService transaction;
        public MainForm()
        {
            InitializeComponent();
            transaction = new TransactionService();
        }

        private void mainFormTransactionBtn_Click(object sender, EventArgs e)
        {
            var transactionForm = new TransactionForm(transaction);
            transactionForm.Show();
            this.Hide();
        }
    }
}
