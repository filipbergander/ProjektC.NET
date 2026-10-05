using static System.Console;
using Projekt.Models;

namespace Projekt.Services
{
    public class TransactionService    {
     
        private readonly List<Transaction> transactions = new List<Transaction>();

        public void AddTransaction(string? type, string? title, string? category, float amount)
        {
            var transaction = new Transaction(type, title, category, amount);
            transactions.Add(transaction);
        }
        public List<Transaction> GetTransactions()
        {
              return transactions;
        }
    }
}
