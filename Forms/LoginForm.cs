using Projekt.Forms;
using Projekt.Interfaces;
using Projekt.Models;
using Projekt.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Projekt.Forms
{
    public partial class LoginForm : Form
    {
        // Variabler för att hålla reda på inloggad användare och sin roll
        public string LoggedInUsername { get; private set; } = string.Empty;
        public string LoggedInRole { get; private set; } = string.Empty;
        // Instans
        private readonly IUserService userService;
        public LoginForm(IUserService userService)
        {
            InitializeComponent();
            this.userService = userService;
        }
        // Vid klick på logga in-knappen
        private async void loginButton_Click(object sender, EventArgs e)
        {
            // Sätter felmeddelandet till rött
            msgLabel.ForeColor = Color.Red;
            msgLabel.Text = "";

            // Skapar en lista av alla felmeddelanden
            List<string> errors = new List<string>();

            // Validerar inputs
            if (string.IsNullOrEmpty(userNameText.Text))
            {
                errors.Add("* Fyll i användarnamn!");
            }

            // lösenord
            if (string.IsNullOrEmpty(passwordText.Text))
            {
                errors.Add("* Fyll i lösenord!");
            }

            // Om felmeddelanden finns, visas dem
            if (errors.Count > 0)
            {
                userMsgPanel.Visible = true; // Visar panelen med felmeddelanden
                msgLabel.Text = string.Join("\n", errors); // Radbryter varje felmeddelande
                return;
            }
            // Sparar ned inmatade användarnamnet och lösenordet
            string username = userNameText.Text.Trim();
            string password = passwordText.Text.Trim();

            // Autentiserar den inmatade användaren
            var user = await userService.AuthenticateUser(username, password);
            if (user == null)
            {
                userMsgPanel.Visible = true; // Visar panelen med felmeddelanden
                msgLabel.Text = "* Felaktigt användarnamn eller \n lösenord!";
                return;
            }
            LoggedInUsername = user.Username ?? string.Empty;
            LoggedInRole = user.Role ?? string.Empty;
            // Öppnar MainForm
            this.DialogResult = DialogResult.OK;
            this.Close();
            // Nollställer textfälten vid lyckad inloggning
            userNameText.Text = string.Empty;
            passwordText.Text = string.Empty;
        }
        // Stänger av applikationen
        private void ExitAppMenu_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
