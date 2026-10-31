/*
* Projektuppgift, Mittuniversitetet 2026
* Filnamn: Program.cs
* Författare: Filip Bergander
* Datum: 2026-10-31
* Kurs: Programmering i C#.NET
*
* Beskrivning:
* En WinForms-applikation som hanterar användarens utgifter och inkomster,
* med möjlighet att logga in, registrera nya användare, hantera transaktioner, beräkna sparande samt spela en sparutmaning. 
* Applikationen använder sig av en SQLite-databas för att lagra användare och transaktioner.
*/

using Projekt.Forms;
using Projekt.Interfaces;
using Projekt.Services;
using System.Data;
using static System.Console;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Projekt.Models;

namespace Projekt
{
    internal static class Program
    {

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            // Instanser av services genom interfaces
            IUserService userService = new UserService();
            ITransactionService transactionService = new TransactionService();

            // Applikationen börjar från loginform
            LoginForm loginForm = new LoginForm(userService);
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                // Skickar med användarnamn och roll till mainform för att visa i en panel
                string username = loginForm.LoggedInUsername;
                string role = loginForm.LoggedInRole;
                Application.Run(new MainForm(transactionService, username, role)); // Applikationen körs via mainform
            }
            // Användes under testutvecklingen av applikationen
            //Application.Run(new MainForm(transactionService, "null", "null"));
        }
    }
}