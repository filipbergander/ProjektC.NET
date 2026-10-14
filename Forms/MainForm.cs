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
    public partial class MainForm : Form
    {
        private readonly TransactionService transaction;
        private readonly FinanceService financeService;
        public MainForm()
        {
            InitializeComponent();
            transaction = new TransactionService();
            financeService = new FinanceService(transaction);
            InsertValues();
        }

        private void mainFormTransactionBtn_Click(object sender, EventArgs e)
        {
            var transactionForm = new TransactionForm(transaction, this);
            OpenForm(transactionForm);
        }

        private void OpenForm(Form form)
        {
            form.FormClosed += (s, args) =>
            {
                this.Show();
                InsertValues();
            };
            form.Show();
            this.Hide();
        }
        // Hämtar in värdena som metoden i financeService kalkylerat och returnerar dem i labels ínom mainform
        private async void InsertValues()
        {
            // Värdena från financeservice
            var (monthBalanceSum, incomeSum, expenseSum) = await financeService.InsertFinanceValues();
            // Labels inom layoutpanel
            monthValueLabel.Text = $"{monthBalanceSum:N2} kr";
            totalIncomeLabel.Text = $"{incomeSum:N2} kr";
            totalExpenseLabel.Text = $"{expenseSum:N2} kr";
        }
    }
}
