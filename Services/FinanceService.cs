using static System.Console;
using Projekt.Models;
using Microsoft.EntityFrameworkCore;
using Projekt.Data;
using System.Runtime.InteropServices.Marshalling;

namespace Projekt.Services
{
    internal class FinanceService
    {
        private readonly TransactionService transaction;

        public FinanceService(TransactionService transaction)
        {
            this.transaction = transaction;
        }


        public async Task<(float MonthBalanceSum, float IncomeSum, float ExpenseSum)> InsertFinanceValues()
        {
            List<Transaction> allTransactions = await transaction.GetTransactions();
            string currentYearMonth = DateTime.Now.ToString("yyyy-MM");
            var monthBalanceSum = allTransactions.Where(t => t.Datum != null && t.Datum.StartsWith(currentYearMonth) && t.Typ == "Inkomst").Sum(t => t.Belopp) -
                allTransactions.Where(t => t.Datum != null && t.Datum.StartsWith(currentYearMonth) && t.Typ == "Utgift").Sum(t => t.Belopp);

            var incomeSum = allTransactions.Where(t => t.Datum != null && t.Datum.StartsWith(currentYearMonth) && t.Typ == "Inkomst").Sum(t => t.Belopp);

            var expenseSum = allTransactions.Where(t => t.Datum != null && t.Datum.StartsWith(currentYearMonth) && t.Typ == "Utgift").Sum(t => t.Belopp);
            return (monthBalanceSum, incomeSum, expenseSum);
        }
    }
}
