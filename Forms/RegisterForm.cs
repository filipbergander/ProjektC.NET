using Projekt.Interfaces;
using Projekt.Models;
using Projekt.Services;
using Projekt.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Projekt.Forms
{
    public partial class newUserRegisterForm : Form
    {
        // Instanser
        private readonly IUserService userService;

        public newUserRegisterForm(IUserService userService)
        {
            InitializeComponent();
            this.userService = userService;
        }

        private async void createUserButton_Click(object sender, EventArgs e)
        {
            // Sätter felmeddelandet till rött
            msgLabel.ForeColor = Color.Red;
            msgLabel.Text = "";

            // Skapar en lista av alla felmeddelanden
            List<string> errors = new List<string>();

            // Användarnamn
            if (string.IsNullOrEmpty(newUsernameText.Text))
            {
                errors.Add("* Fyll i användarnamn!");
            }

            // Tittar om lösenorden är tomma 
            if (string.IsNullOrEmpty(newUsernameText.Text) || string.IsNullOrEmpty(newUserPasswordText.Text) || string.IsNullOrEmpty(newUserConfirmPasswordText.Text))
            {
                errors.Add("* Fyll i lösenorden!");
            }
            // Om inte en roll har valts
            if (string.IsNullOrEmpty(newUserRoleCombo.SelectedItem?.ToString() ?? string.Empty))
            {
                errors.Add("* Välj en roll för användaren!");
            }

            // Om inte lösenorden matchar med varandra -> felmeddelande
            if (newUserPasswordText.Text != newUserConfirmPasswordText.Text)
            {
                errors.Add("* Lösenorden matchar inte!");
            }

            // Om felmeddelanden finns, visas dem
            if (errors.Count > 0)
            {
                userMsgPanel.Visible = true; // Visar panelen med felmeddelanden
                msgLabel.Text = string.Join("\n", errors); // Radbryter varje felmeddelande
                return;
            }

            // Sparar ned den inmatade informationen
            string username = newUsernameText.Text.Trim();
            string role = newUserRoleCombo.SelectedItem?.ToString() ?? string.Empty;
            string password = newUserPasswordText.Text.Trim();
            //string confirmPassword = newUserConfirmPasswordText.Text.Trim();

            // Gör första bokstaven i användarnamnet till stor bokstav
            //username = char.ToUpper(username[0]) + username.Substring(1);
            User newUser = new User(username, role, password);

            // Provar lägga till användaren i databasen
            bool added = await userService.CreateUser(newUser);
            await UIEnhancer.RunLoadingBar(progressBar, createUserButton); // Kör progressbaren
            if (!added)
            {
                userMsgPanel.Visible = true; // Visar panelen med felmeddelanden
                msgLabel.Text = "Användaren kunde inte skapas. Användarnamnet finns redan...";
                return;
            }
            // Skapar användaren i databasen
            await userService.CreateUser(newUser);

            // Nollställer textfälten & felmeddelanden vid lyckad registrering
            ResetForm();
        }
        // Stänger formuläret och går tillbaka till mainform
        private void addTransactionFormReturnBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // När formuläret laddas läggs rollerna till i comboboxen
        private void newUserRegisterForm_Load(object sender, EventArgs e)
        {
            // Specifika roller
            newUserRoleCombo.Items.Add("Admin");
            newUserRoleCombo.Items.Add("Lärare");
            newUserRoleCombo.Items.Add("Student");
        }

        private void ResetForm()
        {
            newUsernameText.Clear();
            newUserRoleCombo.SelectedIndex = 0;
            newUserPasswordText.Clear();
            newUserConfirmPasswordText.Clear();
            msgLabel.Text = string.Empty;
            userMsgPanel.Visible = false;
        }
    }
}
