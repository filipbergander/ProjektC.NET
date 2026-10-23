using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Projekt.Forms;
using Projekt.Models;
using Projekt.Services;
using Projekt.Interfaces;

namespace Projekt.Forms
{
    public partial class AddTransactionForm : Form
    {
        // Instans av TransactionService
        private readonly ITransactionService transaction;
        private readonly Transaction? transactionToEdit;
        private readonly TransactionForm transactionForm;
        private readonly QueryService queryService;

        // Konstruktor som initierar AddTransactionForm, samt instans av en ny Transaction
        public AddTransactionForm(ITransactionService transaction, TransactionForm transactionForm, QueryService queryService, Transaction? transactionToEdit = null)
        {
            InitializeComponent(); // Startar upp formuläret med alla komponenter
            this.transaction = transaction;
            this.transactionForm = transactionForm;
            this.queryService = queryService;
            this.transactionToEdit = transactionToEdit;
           LoadCategories();
            if (transactionToEdit != null)
            {
                addTransactionLabel.Text = "Redigera transaktion";
                saveAddTransactionBtn.Text = "Spara ändringar";
                LoadTransactionsToEdit(transactionToEdit.Id, transactionToEdit);

            }

        }
        // Vid klick på knappen "Spara" läggs den nya transaktionen till i listan av transaktioner & i databasen
        private async void SaveAddTransactionBtn_Click(object sender, EventArgs e)
        {

            // Sätter felmeddelandet till rött
            msgLabel.ForeColor = Color.Red;
            msgLabel.Text = "";

            // Skapar en lista av alla felmeddelanden
            List<string> errors = new List<string>();

            // Validerar inputs och lägger till eventuella felmeddelanden i listan 
            if (addTransactionTypeComboBox.SelectedItem == null)
            {
                errors.Add("* Välj typ för transaktionen!");
            }
            // Titel
            if (string.IsNullOrWhiteSpace(addTransactionTitleText.Text))
            {
                errors.Add("* Ange titel för transaktionen!");
            }
            // Kategori
            if (string.IsNullOrWhiteSpace(addTransactionCategoryCombo.Text))
            {
                errors.Add("* Ange kategori för transaktionen!");
            }
            // Om angivet belopp är 0 eller mindre
            if (addTransactionAmountNum.Value <= 0)
            {
                errors.Add("* Beloppet behöver vara mer än 0!");
            }
            // Om angivet belopp är över 100 000 sek
            if (addTransactionAmountNum.Value > 100_000)
            {
                errors.Add("* Beloppet kan inte vara mer än 100 000!");
            }
            // Om det finns felmeddelanden i listan så visas dem i msgLabel och metoden körs inte vidare
            if (errors.Count > 0)
            {
                // Radbryter varje felmeddelande
                msgLabel.Text = string.Join("\n", errors);
                return;
            }

            // Hämtar in värdena i inputsen 
            string? type = addTransactionTypeComboBox.SelectedItem?.ToString()!;
            string? title = addTransactionTitleText.Text;
            string? category = addTransactionCategoryCombo.Text;
            float amount = (float)addTransactionAmountNum.Value;
            DateTime date = addTransactionDatePicker.Value;

            // Gör första bokstaven till stor bokstav
            title = char.ToUpper(title[0]) + title.Substring(1);
            category = char.ToUpper(category[0]) + category.Substring(1);
            string? dateStr = date.ToString("yyyy-MM-dd");

            // Lägger till den specifika transaktionen i listan av transaktioner
            Transaction newTransaction = new Transaction(type, title, category, amount, dateStr);

            if (transactionToEdit == null)
            {
                bool added = await transaction.AddTransaction(newTransaction);

                if (!added)
                {
                    msgLabel.ForeColor = Color.Red;
                    msgLabel.Text = "Transaktionen finns redan!";
                    return;
                }
            }
            else if (transactionToEdit != null)
            {
                await transaction.UpdateTransaction(transactionToEdit.Id, newTransaction);
            }

            // Återställer inputs
            ResetForm();
            // Visar "lyckat-meddelande" beroende på vilken transaktion som görs i UI, sätter även textfärgen till grön
            msgLabel.ForeColor = Color.Green;
            msgLabel.Text = transactionToEdit == null ? "Transaktionen har lagts till!" : "Transaktionen har uppdaterats!";
        }
        // Går tillbaka till transaktionerna -> vid klick på "Gå tillbaka"
        private void AddTransactionFormReturnBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Sätter in värdena i combooxen för Typ
        private void AddTransactionForm_Load(object sender, EventArgs e)
        {
            addTransactionTypeComboBox.Items.Add("Utgift");
            addTransactionTypeComboBox.Items.Add("Inkomst");
            addTransactionTypeComboBox.SelectedIndex = 0;
        }
        // Vid klick på "Avbryt" återställs inputs
        private void addTransactionCancelBtn_Click(object sender, EventArgs e)
        {

            ResetForm();
        }
        // Återställer inputs & ev felmeddelanden i formuläret
        private void ResetForm()
        {
            addTransactionAmountNum.Value = 0;
            addTransactionTypeComboBox.SelectedIndex = 0;
            addTransactionTitleText.Clear();
            addTransactionCategoryCombo.Text = "";
            addTransactionDatePicker.Value = DateTime.Now;
            msgLabel.Text = "";
        }
        // Stänger sidan för att lägga till en transaktion
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Hämtar in värdena från den transaktion som ska redigeras och fyller i inputs med dessa värden
        private void LoadTransactionsToEdit(int id, Transaction transactionToEdit)
        {
            // Uppdaterar inputs med värdena från den transaktion som ska redigeras
            addTransactionTypeComboBox.SelectedItem = transactionToEdit.Typ;
            addTransactionTitleText.Text = transactionToEdit.Namn;
            addTransactionCategoryCombo.Text = transactionToEdit.Kategori;
            addTransactionAmountNum.Value = (decimal)transactionToEdit.Belopp;
            addTransactionDatePicker.Value = DateTime.Parse(transactionToEdit.Datum ?? DateTime.Now.ToString());
        }

        private async void LoadCategories()
        {
            var categories = await queryService.GetCategoryValues();
            addTransactionCategoryCombo.BeginUpdate();
            addTransactionCategoryCombo.Items.Clear();
            addTransactionCategoryCombo.Items.AddRange(categories.ToArray());
            addTransactionCategoryCombo.EndUpdate();
        }
    }
}
