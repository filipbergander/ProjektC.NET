using Projekt.Forms;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Projekt.Forms
{
    public partial class LoginForm : Form
    {
        private readonly IUserService userService;
        public LoginForm(IUserService userService)
        {
            InitializeComponent();
            this.userService = userService;
        }

        private async void loginButton_Click(object sender, EventArgs e)
        {
            // Sätter felmeddelandet till rött
            msgLabel.ForeColor = Color.Red;
            msgLabel.Text = "";

            // Skapar en lista av alla felmeddelanden
            List<string> errors = new List<string>();

            // Användarnamn
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
            await UIEnhancer.RunLoadingBar(progressBar, loginButton); // Kör progressbaren
            // Sparar ned inmatade användarnamnet och lösenordet
            string username = userNameText.Text.Trim();
            string password = passwordText.Text.Trim();

            // Tittar om användarnamn och lösenord är tomma 
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Fyll i både användarnamn och lösenord!");
                return;
            }

            // Nollställer textfälten vid lyckad inloggning
            userNameText.Text = string.Empty;
            passwordText.Text = string.Empty;


        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
