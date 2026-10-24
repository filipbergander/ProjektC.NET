using Projekt.Interfaces;
using Projekt.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Projekt.Forms
{
    public partial class AboutForm : Form

    {
        // Instans av sidan som användare befann sig på innan den navigera till om-sidan
        private readonly Form parentForm;
        public AboutForm(Form parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }
        // Stänger av applikationen
        private void ExitAppMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // Går tillbaka till föregående sida
        private void savingsFormReturnBtn_Click(object sender, EventArgs e)
        {
            parentForm.Show();
            this.Close();
        }
    }
}