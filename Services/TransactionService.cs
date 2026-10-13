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

        public async Task<List<Transaction>> GetTransactionsSorted(string columnClicked)
        {
            return columnClicked switch
            {
                nameof(Transaction.Typ) => await database.Set<Transaction>().OrderBy(t => t.Typ).ToListAsync(),
                nameof(Transaction.Namn) => await database.Set<Transaction>().OrderBy(t => t.Namn).ToListAsync(),
                nameof(Transaction.Kategori) => await database.Set<Transaction>().OrderBy(t => t.Kategori).ToListAsync(),
                nameof(Transaction.Belopp) => await database.Set<Transaction>().OrderBy(t => t.Belopp).ToListAsync(),
                nameof(Transaction.Datum) => await database.Set<Transaction>().OrderBy(t => t.Datum).ToListAsync(),

                _ => await database.Set<Transaction>().ToListAsync()
            };
        }
    }
}
