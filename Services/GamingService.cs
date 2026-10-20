using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using Projekt.Models;
using Projekt.Interfaces;
using Microsoft.EntityFrameworkCore;
using Projekt.Data;

namespace Projekt.Services
{
    public class GamingService
    {
        // Instans av Transactionsservicen
        private readonly ITransactionService transaction;

        public GamingService(ITransactionService transaction)
        {
            this.transaction = transaction;
        }
        // Hämtar in hur många gånger man spelat på sparutmaningen under dagen -> för att avgöra om man kan spela eller inte
        public async Task<bool> CanPlayToday()
        {
            var today = DateTime.Today.ToString("yyyy-MM-dd"); // Dagens datum

            var transactions = await transaction.GetTransactions(); // Hämtar alla transaktioner

            // Tittar om det finns två "Sparande" poster från samma dag 
            if (transactions.Count(t => t.Kategori == "Sparande" && t.Datum == today) >= 2)
            {
                return false;
            }
            return true;
        }
        // Räknar ut hur många gånger användaren har spelat sparutmaningen under dagen -> för att visa i savingsForm
        public async Task<int> GetAmountsPlayedToday()
        {
            var transactions = await transaction.GetTransactions(); // Hämtar in alla transaktioner från databasen
            // Returnerar antalet transaktioner som innehåller "Sparutmaning" i namnet och har dagens datum
            return transactions.Count(t => t.Namn?.Contains("Sparutmaning") == true && DateTime.TryParse(t.Datum, out DateTime date) && date.Date == DateTime.Today);
        }

        public float GetPlayerBalanceTransformToModel(decimal actualBalance)
        {
            if (actualBalance <= 2000) return 1;
            else if (actualBalance <= 5000) return 2;
            else if (actualBalance <= 10000) return 3;
            else if (actualBalance <= 20000) return 4;
            else return 5;
        }

            }
}
