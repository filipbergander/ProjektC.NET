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

namespace Projekt.Forms
{
    public partial class AddTransactionForm : Form
    {
        // Instans av TransactionService
        private readonly TransactionService _transaction;

        // Konstruktor som initierar AddTransactionForm, samt instans av en ny Transaction
        public AddTransactionForm(TransactionService transaction)
        {
            InitializeComponent(); // Startar upp formuläret med alla komponenter
            _transaction = transaction;
        }
        // Vid klick på knappen "Spara" läggs den nya transaktionen till i listan av transaktioner & i databasen
        private async void SaveAddTransactionBtn_Click(object sender, EventArgs e)
        {
            // Sätter felmeddelandet till rött
            errorLabel.ForeColor = Color.Red;
            errorLabel.Text = "";

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
            if (string.IsNullOrWhiteSpace(addTransactionCategoryText.Text))
            {
                errors.Add("* Ange kategori för transaktionen!");
            }
            // Om angivet belopp är 0 eller mindre
            if (addTransactionAmountNum.Value <= 0)
            {
                errors.Add("* Beloppet behöver vara mer än 0!");
            }
            // Om angivet belopp är över 100 000 sek
            else if (addTransactionAmountNum.Value > 100_000)
            {
                errors.Add("* Beloppet kan inte vara mer än 100 000!");
            }
            // Om det finns felmeddelanden i listan så visas dem i errorLabel och metoden körs inte vidare
            if (errors.Count > 0)
            {
                // Radbryter varje felmeddelande
                errorLabel.Text = string.Join("\n", errors);
                return;
            }

            // Hämtar in värdena i inputsen 
            string? type = addTransactionTypeComboBox.SelectedItem?.ToString()!;
            string? title = addTransactionTitleText.Text;
            string? category = addTransactionCategoryText.Text;
            float amount = (float)addTransactionAmountNum.Value;

            // Gör första bokstaven till stor bokstav
            title = char.ToUpper(title[0]) + title.Substring(1);
            category = char.ToUpper(category[0]) + category.Substring(1);

            // Lägger till den specifika transaktionen i listan av transaktioner
            await _transaction.AddTransaction(type, title, category, amount);

            // Återställer inputs
            ResetForm();
            // Visar "success-meddelande" i UI, sätter även textfärgen till grön
            errorLabel.ForeColor = Color.Green;
            errorLabel.Text = "Transaktionen har lagts till!";
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
            addTransactionCategoryText.Clear();
            errorLabel.Text = "";
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
