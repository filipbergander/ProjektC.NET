using System;
using System.Collections.Generic;
using System.Text;
using Projekt.Models;

namespace Projekt.Interfaces
{
    // Interface för TransactionService
    public interface ITransactionService
    {
        Task<bool> AddTransaction(Transaction transaction); // Metod för att lägga till en transaktion
        Task RemoveTransaction(int id); // Metod för att ta bort en transaktion
        Task<List<Transaction>> GetTransactions(); // Metod för att hämta alla transaktioner
        Task UpdateTransaction(int id, Transaction transaction); // Metod för att uppdatera en befintlig transaktion

        //Tillfällig metod: för att kunna ta bort alla transaktioner som innehåller "Sparutmaning" i namnet
        //Task RemoveChallengeTransactions();
    }
}
