using static System.Console;
using Projekt.Models;
using Microsoft.EntityFrameworkCore;
using Projekt.Data;
using System.Runtime.InteropServices.Marshalling;
using Projekt.Interfaces;
using System.Data.Common;

namespace Projekt.Services
{
    public class TransactionService : ITransactionService
    {
        //private readonly List<Transaction> transactions = new List<Transaction>();

        // Instans för att hantera databasen
        private readonly ProjektDbContext database;
        // Konstruktor
        public TransactionService()
        {
            database = new ProjektDbContext();
            database.Database.EnsureCreated();
        }

        // Lägga till en ny transaktion
        public async Task<bool> AddTransaction(Transaction transaction)
        {
            // Kollar om en transaktion redan finns i databasen
            var existingTransaction = await database.Set<Transaction>()
                .AnyAsync(dbTransaction => dbTransaction.Typ == transaction.Typ &&
                dbTransaction.Namn == transaction.Namn &&
                dbTransaction.Kategori == transaction.Kategori &&
                dbTransaction.Belopp == transaction.Belopp &&
                dbTransaction.Datum == transaction.Datum);

            // Transaktionen finns redan, kör inte vidare
            if (existingTransaction)
            {
                return false;
            }

            // Lägger till en ny transaktion i listan av transaktioner
            //var transaction = new Transaction(t.Typ, t.Namn, t.Kategori, t.Belopp, t.Datum);
            // Lägger till ändringarna i minnet
            database.Set<Transaction>().Add(transaction);
            // Sparar ned ändringar till databasen
            await database.SaveChangesAsync();
            return true;
        }
        // Hämtar in alla transaktioner från databasen
        public async Task<List<Transaction>> GetTransactions()
        {
            return await database.Set<Transaction>().ToListAsync();
        }

        // Tar bort en transaktion från databasen
        public async Task RemoveTransaction(int id)
        {
            var transaction = await database.Set<Transaction>().FindAsync(id); // Hittar transaktionen med det inskickade id:t
            // Kollar om transaktionen finns och att den inte innehåller "Sparutmaning" i namnet
            if (transaction != null && !(transaction.Namn?.Contains("Sparutmaning") ?? false)) // 
            {
                database.Set<Transaction>().Remove(transaction); // Tar bort transaktionen från databasen
                await database.SaveChangesAsync(); // Sparar ändringarna
            }
        }
    }
}