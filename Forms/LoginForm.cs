using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Models;

namespace Forms
{
    public partial class loginForm : Form
    {

        private string userName;
        private string passWord;

        public loginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
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

    }
}
