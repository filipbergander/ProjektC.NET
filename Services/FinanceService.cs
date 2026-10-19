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
                .Where(t => t.Typ == "Utgift")
                .GroupBy(t => t.Kategori)
                .Select(g => (Category: g.Key ?? "Okänd", Sum: g.Sum(t => t.Belopp)
                ))
                .ToList();
        }
        // Hämtar in hur många gånger man spelat på sparutmaningen under dagen -> för att avgöra om man kan spela eller inte
        public async Task<bool> CanPlayToday()
        {
            var today = DateTime.Today.ToString("yyyy-MM-dd"); // Dagens datum

            var transactions = await transaction.GetTransactions(); // Hämtar alla transaktioner

            // Tittar om det finns två "Sparande" poster från samma dag 
            if (transactions.Count(t => t.Kategori == "Sparande" && t.Datum == today) >= 2)
            {
                return false;
            }
            return true;
        }
    }
}
