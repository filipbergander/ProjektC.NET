using Projekt.Forms;
using Projekt.Interfaces;
using Projekt.Services;
using System.Data;
using static System.Console;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
            IUserService userService = new UserService();
            ITransactionService transactionService = new TransactionService();
            Application.Run(new MainForm(transactionService, "null", "null"));
            /* LoginForm loginForm = new LoginForm(userService, transactionService);
             if (loginForm.ShowDialog() == DialogResult.OK)
             {
                 string username = loginForm.LoggedInUsername;
                 string role = loginForm.LoggedInRole;
                 Application.Run(new MainForm(transactionService, username, role));
             }*/
        }
    }
}