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
        // Instanser
        //private readonly MainForm mainForm;
        private readonly IUserService userService;
        private readonly ITransactionService transaction;
        public LoginForm(IUserService userService, ITransactionService transaction)
        {
            InitializeComponent();
            this.userService = userService;
            this.transaction = new TransactionService();
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
            // Sparar ned inmatade användarnamnet och lösenordet
            string username = userNameText.Text.Trim();
            string password = passwordText.Text.Trim();

            bool authenticated = await userService.AuthenticateUser(username, password);
            if (!authenticated)
            {
                userMsgPanel.Visible = true; // Visar panelen med felmeddelanden
                msgLabel.Text = "* Felaktigt användarnamn eller \n lösenord!";
                return;
            }

            // Öppnar MainForm
            this.DialogResult = DialogResult.OK;
            this.Close();
            // Nollställer textfälten vid lyckad inloggning
            userNameText.Text = string.Empty;
            passwordText.Text = string.Empty;
        }
    }
}
