using Forms;
using ProjektC_.NET.Forms;
using static System.Console;
using Services;

namespace ProjektC_.NET
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new AddTransactionForm());
        }
    }
}