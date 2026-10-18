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
            ITransactionService transactionService = new TransactionService();
            Application.Run(new MainForm(transactionService));
        }
    }
}