using System;
using System.Collections.Generic;
using System.Text;
using Projekt.Models;

namespace Projekt.Interfaces
{
    public interface ITransactionService
    {
        Task<bool> AddTransaction(Transaction transaction);
        Task RemoveTransaction(int id);
        Task<List<Transaction>> GetTransactions();
    }
}
