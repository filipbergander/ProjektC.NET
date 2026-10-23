using static System.Console;
using Projekt.Models;
using Projekt.Interfaces;
using Microsoft.EntityFrameworkCore;
using Projekt.Data;
using System.Runtime.InteropServices.Marshalling;

namespace Projekt.Services
{
    public class FinanceService
    {
        // Instans av Transactionsservicen
        private readonly ITransactionService transaction;
        // Konstruktor
        public FinanceService(ITransactionService transaction)
        {
            this.transaction = transaction;
        }
        // Beräknar för aktuell månad summan av inkomster, utgifter och totala saldo
        public async Task<(float MonthBalanceSum, float IncomeSum, float ExpenseSum, int Quantity)> InsertFinanceValues()
        {
            // Hämtar in alla transaktioner
            List<Transaction> allTransactions = await transaction.GetTransactions();

            // Aktuella månaden
            string currentYearMonth = DateTime.Now.ToString("yyyy-MM");

            // Summan inkomster
            float incomeSum = allTransactions.Where(t => t.Datum != null && t.Datum.StartsWith(currentYearMonth) && t.Typ == "Inkomst").Sum(t => t.Belopp);

            // Summan utgifter
            float expenseSum = allTransactions.Where(t => t.Datum != null && t.Datum.StartsWith(currentYearMonth) && t.Typ == "Utgift").Sum(t => t.Belopp);

            // Totala saldot
            float monthBalanceSum = incomeSum - expenseSum;

            int quantity = allTransactions.Count;

            return (monthBalanceSum, incomeSum, expenseSum, quantity);
        }
        // Beräknar summan av utgifter per kategori
        public async Task<List<(string Category, float Sum)>> GetExpensesByCategory()
        {
            var transactions = await this.transaction.GetTransactions(); // Hämtar in transaktioner
            // Filtrerar ut utgifterna och grupperar dem efter kategori, samt summerar beloppet för varje kategori
            return transactions
                .Where(t => t.Typ == "Utgift" && t.Kategori != "Sparande")
                .GroupBy(t => t.Kategori)
                .Select(g => (Category: g.Key ?? "Okänd", Sum: g.Sum(t => t.Belopp)
                ))
                .ToList();
        }
        // Hämtar in alla transaktioner och beräknar totala saldot, inte bara för en specifik månad
        public async Task<float> GetTotalBalance()
        {
            List<Transaction> transactions = await transaction.GetTransactions(); // Hämtar in alla transaktioner
            float incomeSum = transactions.Where(t => t.Typ == "Inkomst").Sum(t => t.Belopp); // Summa inkomster
            float expenseSum = transactions.Where(t => t.Typ == "Utgift").Sum(t => t.Belopp);// Summa utgifter
            return incomeSum - expenseSum; // Returnerar totala saldot
        }


        /// <summary>
        /// Räknar ut hur mycket pengar man kommer ha efter ett visst antal år, med startbelopp, avsättning per månad och årlig ränta.   
        /// </summary>
        /// <param name="startAmount"> Startbelopp av pengar</param>
        /// <param name="monthlyInvest"> Hur mycket pengar som avsätts varje månad</param>
        /// <param name="annualInterestRate">Årliga räntan</param>
        /// <param name="years"> Antal år som man vill spara</param>
        /// <returns> Det totala beloppet efter angivet antal år</returns>
        public decimal CalculateFutureSavings(decimal startAmount, decimal monthlyInvest, double annualInterestRate, int years)
        {
            double monthlyRate = annualInterestRate / 12; // Ränta per månad, t.ex om förväntad ränta per år för avkastningen är 6% så är månadsräntan: 0.5%
            int totalMonths = years * 12; // Totalt antal månader

            decimal totalAmount = startAmount; // Totala beloppet börjar med startbeloppet, t.ex att man börjar på 5000 kr

            for (int i = 0; i < totalMonths; i++)
            {
                // Lägger till hur mycket man vill avsätta varje månad, t.ex 500 kr
                totalAmount += monthlyInvest;

                totalAmount *= (decimal)(1 + monthlyRate); // Lägger till räntan på det totala beloppet, t.ex 0.5% per månad
            }
            // Det totala beloppet avrundat med två decimaler
            return Math.Round(totalAmount, 2);
        }
    }
}
