using static System.Console;
using Projekt.Models;
using Projekt.Interfaces;
using Microsoft.EntityFrameworkCore;
using Projekt.Data;
using System.Runtime.InteropServices.Marshalling;

namespace Projekt.Services
{
    internal class FinanceService
    {
        // Instans av Transactionsservicen
        private readonly ITransactionService transaction;
        // Konstruktor
        public FinanceService(ITransactionService transaction)
        {
            this.transaction = transaction;
        }
        // Beräknar för aktuell månad summan av inkomster, utgifter och totala saldo
        public async Task<(float MonthBalanceSum, float IncomeSum, float ExpenseSum)> InsertFinanceValues()
        {
            // Hämtar in alla transaktioner
            List<Transaction> allTransactions = await transaction.GetTransactions();

            // Aktuella månaden
            string currentYearMonth = DateTime.Now.ToString("yyyy-MM");

            // Summan inkomster
            var incomeSum = allTransactions.Where(t => t.Datum != null && t.Datum.StartsWith(currentYearMonth) && t.Typ == "Inkomst").Sum(t => t.Belopp);

            // Summan utgifter
            var expenseSum = allTransactions.Where(t => t.Datum != null && t.Datum.StartsWith(currentYearMonth) && t.Typ == "Utgift").Sum(t => t.Belopp);

            // Totala saldot
            var monthBalanceSum = incomeSum - expenseSum;

            return (monthBalanceSum, incomeSum, expenseSum);
        }
    }
}
