using Projekt.Forms;
using static System.Console;
using Projekt.Services;
using Projekt.Interfaces;

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
            LoginForm loginForm = new LoginForm(userService, transactionService);
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new MainForm(transactionService));
            }
        }
    }
}