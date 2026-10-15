using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Projekt.Data;
using Projekt.Models;
using Projekt.Services;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using static System.Console;

namespace Projekt.Services
{
    internal class QueryService
    {
        // Instans av Transactionsservicen
        private readonly TransactionService transaction;

        public QueryService(TransactionService transaction)
        {
            this.transaction = transaction;
        }

        public async Task<List<Transaction>> GetSortedTransactions(string columnClicked, bool ascending)
        {
            var transactions = await transaction.GetTransactions();
            IEnumerable<Transaction> sortedTranscations = columnClicked switch
            {
                nameof(Transaction.Id) => ascending ? transactions.OrderBy(t => t.Id) : transactions.OrderByDescending(t => t.Id),
                nameof(Transaction.Typ) => ascending ? transactions.OrderBy(t => t.Typ) : transactions.OrderByDescending(t => t.Typ),
                nameof(Transaction.Namn) => ascending ? transactions.OrderBy(t => t.Namn) : transactions.OrderByDescending(t => t.Namn),
                nameof(Transaction.Kategori) => ascending ? transactions.OrderBy(t => t.Kategori) : transactions.OrderByDescending(t => t.Kategori),
                nameof(Transaction.Belopp) => ascending ? transactions.OrderBy(t => t.Typ == "Utgift").ThenBy(t => t.Belopp) : transactions.OrderByDescending(t => t.Typ == "Utgift").ThenByDescending(t => t.Belopp),
                nameof(Transaction.Datum) => ascending ? transactions.OrderBy(t => t.Datum) : transactions.OrderByDescending(t => t.Datum),
                _ => transactions
            };
            return sortedTranscations.ToList();
        }

        public async Task<List<string>> GetCategoryValues()
        {
            var transactions = await transaction.GetTransactions();
            return transactions
                .Select(t => t.Kategori)
                .Where(k => !string.IsNullOrEmpty(k))
                .Distinct()
                .OrderBy(c => c)
                .ToList()!;
        }

        public async Task<List<string>> GetTypeValues()
        {
            var transactions = await transaction.GetTransactions();
            return transactions
                .Select(t => t.Typ)
                .Where(t => !string.IsNullOrEmpty(t))
                .Distinct()
                .OrderBy(t => t)
                .ToList()!;
        }

    }
}
