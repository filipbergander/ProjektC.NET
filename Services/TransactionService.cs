using static System.Console;
using Projekt.Models;
using Microsoft.EntityFrameworkCore;
using Projekt.Data;
using System.Runtime.InteropServices.Marshalling;

namespace Projekt.Services
{
    public class TransactionService
    {

        //private readonly List<Transaction> transactions = new List<Transaction>();

        private readonly ProjektDbContext database;
        // Konstruktor
        public TransactionService()
        {
            database = new ProjektDbContext();
            database.Database.EnsureCreated();
        }

        // Lägga till en ny transaktion
        public async Task AddTransaction(string? type, string? title, string? category, float amount)
        {
            // Lägger till en ny transaktion i listan av transaktioner
            var transaction = new Transaction(type, title, category, amount);
            // Lägger till ändringarna i minnet
            database.Set<Transaction>().Add(transaction);
            // Sparar ned ändringar till databasen
            await database.SaveChangesAsync();
        }

        public async Task<List<Transaction>> GetTransactions()
        {
            return await database.Set<Transaction>().ToListAsync();
        }

        public async Task<List<Transaction>> GetSortedTransactions(string columnClicked, bool ascending)
        {
            var transactions = await GetTransactions();
            IEnumerable<Transaction> sortedTranscations = columnClicked switch
            {
                nameof(Transaction.Id) => ascending ? transactions.OrderBy(t => t.Id) : transactions.OrderByDescending(t => t.Id),
                nameof(Transaction.Typ) => ascending ? transactions.OrderBy(t => t.Typ) : transactions.OrderByDescending(t => t.Typ),
                nameof(Transaction.Namn) => ascending ? transactions.OrderBy(t => t.Namn) : transactions.OrderByDescending(t => t.Namn),
                nameof(Transaction.Kategori) => ascending ? transactions.OrderBy(t => t.Kategori) : transactions.OrderByDescending(t => t.Kategori),
                nameof(Transaction.Belopp) => ascending ? transactions.OrderBy(t => t.Belopp) : transactions.OrderByDescending(t => t.Belopp),
                nameof(Transaction.Datum) => ascending ? transactions.OrderBy(t => t.Datum) : transactions.OrderByDescending(t => t.Datum),
                _ => transactions
            };
            return sortedTranscations.ToList();
        }
    }
}