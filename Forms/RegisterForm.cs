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
        private readonly MainForm mainForm;

        public newUserRegisterForm(IUserService userService, MainForm mainForm)
        {
            InitializeComponent();
            this.userService = userService;
            this.mainForm = mainForm;
        }
        // Vid klick på skapa användare
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
            else if (newUsernameText.Text.Length < 3)
            {
                errors.Add("* Användarnamnet kräver minst 3 tecken!");
            }
            else if (newUsernameText.Text.Length > 12)
            {
                errors.Add("* Användarnamnet får max vara 12 tecken!");
            }

            // Tittar om lösenorden är tomma samt giltig längd
            if (string.IsNullOrEmpty(newUserPasswordText.Text) || string.IsNullOrEmpty(newUserConfirmPasswordText.Text))
            {
                errors.Add("* Fyll i lösenorden!");
            }
            else if (newUserPasswordText.Text.Length < 6 || newUserConfirmPasswordText.Text.Length < 6)
            {
                errors.Add("* Lösenordet kräver minst 6 tecken!");
            }
            else if (newUserPasswordText.Text.Length > 12 || newUserConfirmPasswordText.Text.Length > 12)
            {
                errors.Add("* Lösenordet får max vara 12 tecken!");
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

            // Skapar en ny användare genom den inmatade informationen
            User newUser = new User(username, role, password);

            // Provar lägga till användaren i databasen
            bool added = await userService.CreateUser(newUser);
            await UIEnhancer.RunLoadingBar(progressBar, createUserButton); // Kör progressbaren
            // Om användaren inte kunde läggas till -> visa felmeddelande
            if (!added)
            {
                userMsgPanel.Visible = true; // Visar panelen med felmeddelanden
                msgLabel.Text = "* Användaren kunde inte skapas.\n* Användarnamnet finns redan...";
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
            newUserRoleCombo.Items.Add("Privat");
        }
        // Nollställer textfälten & felmeddelanden
        private void ResetForm()
        {
            newUsernameText.Clear();
            newUserRoleCombo.SelectedIndex = 0;
            newUserPasswordText.Clear();
            newUserConfirmPasswordText.Clear();
            msgLabel.Text = string.Empty;
            userMsgPanel.Visible = false;
        }
        // Stänger av appen
        private void avslutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // Navigerar till om-sidan
        private void omToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm(this);
            aboutForm.Show();
            this.Hide();
        }

    }
}
