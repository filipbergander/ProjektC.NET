using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Forms;
using Models;
using Services;

namespace ProjektC_.NET.Forms
{
    public partial class AddTransactionForm : Form
    {

        private readonly TransactionService newTransaction;
        public AddTransactionForm()
        {
            InitializeComponent();
            newTransaction = new();
        }

        private void SaveAddTransactionBtn_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Du försökte lägga till en ny transaktion!");


            string? type = addTransactionTypeComboBox.SelectedItem?.ToString()!;
            string? title = addTransactionTitleText.Text;
            string? category = addTransactionCategoryText.Text;
            float amount = (float)addTransactionAmountNum.Value;

            newTransaction.AddTransaction(type, title, category, amount);
        }

        private void AddTransactionFormReturnBtn_Click(object sender, EventArgs e)
        {
            var transactionForm = new TransactionForm(newTransaction);
            transactionForm.Show();
            this.BeginInvoke(new Action(() => this.Hide()));
        }

        private void AddTransactionForm_Load(object sender, EventArgs e)
        {
            addTransactionTypeComboBox.Items.Add("Inkomst");
            addTransactionTypeComboBox.Items.Add("Utgift");
        }
    }
}
