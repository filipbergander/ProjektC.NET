using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Projekt.Data;
using Projekt.Models;
using Projekt.Services;
using Projekt.Interfaces;
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
        private readonly ITransactionService transaction;

        // Konstruktor
        public QueryService(ITransactionService transaction)
        {
            this.transaction = transaction;
        }
        // Sortering av transaktioner genom att klicka på kolumnnamnet i tabellen, fallande/stigande ordning
        public async Task<List<Transaction>> GetSortedTransactions(List<Transaction> transactions, string columnClicked, bool ascending)
        {
            IEnumerable<Transaction> sortedTranscations = columnClicked switch // Sorterar transaktionerna baserat på kolumnen som klickats på
            {
                nameof(Transaction.Id) => ascending ? transactions.OrderBy(t => t.Id) : transactions.OrderByDescending(t => t.Id), // Id -> borttaget ur gridens vy just nu
                nameof(Transaction.Typ) => ascending ? transactions.OrderBy(t => t.Typ) : transactions.OrderByDescending(t => t.Typ), // Typ
                nameof(Transaction.Namn) => ascending ? transactions.OrderBy(t => t.Namn).ToList() : transactions.OrderByDescending(t => t.Namn).ToList(), // Namn
                nameof(Transaction.Kategori) => ascending ? transactions.OrderBy(t => t.Kategori) : transactions.OrderByDescending(t => t.Kategori), // Kategori

                // Belopp
                nameof(Transaction.Belopp) => ascending ? transactions.OrderBy(t => t.Typ == "Utgift").ThenBy(t => t.Belopp) :
                transactions.OrderByDescending(t => t.Typ == "Utgift").ThenByDescending(t => t.Belopp),
                nameof(Transaction.Datum) => ascending ? transactions.OrderBy(t => t.Datum) : transactions.OrderByDescending(t => t.Datum),// Datum
                _ => transactions // Annars vanlig sortering
            };
            return sortedTranscations.ToList();
        }
        // Hämtar in alla kategorier som lagts till i transaktioner
        public async Task<List<string>> GetCategoryValues()
        {
            var transactions = await transaction.GetTransactions(); // Hämtar in alla transaktioner från databasen
            // Filtrerar ut kategorier
            return transactions
                .Select(t => t.Kategori)
                .Where(k => !string.IsNullOrEmpty(k))
                .Distinct()
                .OrderBy(c => c)
                .ToList()!;
        }
        // Hämtar in alla typer av transaktioner som lagt till i -> listan av transaktioner
        public async Task<List<string>> GetTypeValues()
        {
            var transactions = await transaction.GetTransactions(); // Hämtar in alla transaktioner från databasen
            // Filtrerar ut typ
            return transactions
                .Select(t => t.Typ)
                .Where(t => !string.IsNullOrEmpty(t))
                .Distinct()
                .OrderBy(t => t)
                .ToList()!;
        }

        // Filtrerar transaktionerna beroende på vad användaren har valt i filterpanelen
        public async Task<List<Transaction>> FilterTransactions(TransactionFilter filter)
        {
            var transactions = await transaction.GetTransactions(); // Hämtar in alla transaktioner från databasen
            // Filtrerar ut typer av transaktioner
            if (!string.IsNullOrWhiteSpace(filter.Typ) && filter.Typ != "Alla")
            {
                transactions = transactions.Where(t => t.Typ == filter.Typ).ToList();
            }
            // Filtrerar ut kategorier av transaktioner
            if (filter.Kategori.Count > 0)
            {
                transactions = transactions.Where(t => filter.Kategori.Contains(t.Kategori!)).ToList();
            }

            if (filter.minBelopp.HasValue)
            {
                // Filtrerar ut transaktioner som är större än eller lika med minbeloppet
                transactions = transactions.Where(t => t.Belopp >= filter.minBelopp).ToList();
            }
            if (filter.maxBelopp.HasValue)
            {
                // Filtrerar ut transaktioner som är mindre än eller lika med maxbeloppet
                transactions = transactions.Where(t => t.Belopp <= filter.maxBelopp).ToList();
            }

            // Filtrerar ut från datum av transaktioner
            if (filter.fDatum.HasValue)
            {
                // Alla transaktioner som ligger i framtiden eller samma dag som det valda datumet
                transactions = transactions.Where(t => DateTime.Parse(t.Datum!) >= filter.fDatum).ToList();
            }

            // Filtrerar ut till datum av transaktioner
            if (filter.tDatum.HasValue)
            {
                // Tar alla transaktioner som ligger innan eller samma som det valda datumet
                transactions = transactions.Where(t => DateTime.Parse(t.Datum!) <= filter.tDatum).ToList();
            }
            // Om man sökt på någonting -> ta med det i filtreringen
            if (!string.IsNullOrWhiteSpace(filter.sFras))
            {
                // Filtrerar ut transaktioner som innehåller sökfrasen i Namn, Kategori eller Typ
                transactions = transactions.Where(t => (t.Namn != null && t.Namn.Contains(filter.sFras, StringComparison.OrdinalIgnoreCase)) // Även för gemener och versaler
                    || (t.Kategori?.Contains(filter.sFras, StringComparison.OrdinalIgnoreCase) ?? false)
                    || (t.Typ?.Contains(filter.sFras, StringComparison.OrdinalIgnoreCase) ?? false)).ToList();
            }
            return transactions.ToList();
        }
    }
}
