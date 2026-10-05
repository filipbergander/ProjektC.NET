using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Projekt.Forms
{
    public partial class newUserRegisterForm : Form
    {
        public newUserRegisterForm()
        {
            InitializeComponent();
        }

        private void createUserButton_Click(object sender, EventArgs e)
        {
            // Sparar ned inmatade användarnamnet och lösenorden
            string username = newUsernameText.Text.Trim();
            string password = newUserPasswordText.Text.Trim();
            string confirmPassword = newUserConfirmPasswordText.Text.Trim();

            // Om inte lösenorden matchar med varandra -> felmeddelande
            if (password != confirmPassword)
            {
                MessageBox.Show("Lösenorden matchar inte!");
                return;
            }

            // Tittar om användarnamn och lösenorden är tomma 
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Fyll i både användarnamn och lösenorden!");
                return;
            }

            // Nollställer textfälten vid lyckad inloggning
            newUsernameText.Text = string.Empty;
            newUserPasswordText.Text = string.Empty;
            newUserConfirmPasswordText.Text = string.Empty;
        }
    }
}
