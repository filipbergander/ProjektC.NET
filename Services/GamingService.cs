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
        // Instans
        private readonly ITransactionService transaction;
        private int UserId = SessionService.CurrentUser!.Id; // Hämtar in den inloggade användarens id
        // Konstruktor
        public GamingService(ITransactionService transaction)
        {
            this.transaction = transaction;
        }
        // Hämtar in hur många gånger man spelat på sparutmaningen under dagen -> för att avgöra om man kan spela eller inte
        public async Task<bool> CanPlayToday()
        {
            var today = DateTime.Today.ToString("yyyy-MM-dd"); // Dagens datum

            var transactions = await transaction.GetTransactions(UserId); // Hämtar alla transaktioner

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
            var transactions = await transaction.GetTransactions(UserId); // Hämtar in alla transaktioner från databasen
            // Returnerar antalet transaktioner som innehåller "Sparutmaning" i namnet och har dagens datum
            return transactions.Count(t => t.Namn?.Contains("Sparutmaning") == true && DateTime.TryParse(t.Datum, out DateTime date) && date.Date == DateTime.Today);
        }
        // Det saldo som användaren har görs om till en siffra och sparnivå, 1-5, för att använda i spelet och ML
        public float GetPlayerBalanceTransformToModel(decimal actualBalance)
        {
            if (actualBalance <= 2000) return 1;
            else if (actualBalance <= 5000) return 2;
            else if (actualBalance <= 10000) return 3;
            else if (actualBalance <= 20000) return 4;
            else return 5;
        }

        // Hämtar in den största "vinsten" som användaren vunnít i sparutmaningen
        public async Task<(float LargestWin, float TotalResult)> GetUserResult()
        {
            List<Transaction> transactions = await transaction.GetTransactions(UserId); // Hämtar in alla transaktioner

            var winTransactions = transactions.Where(t => t.Kategori == "Sparande" && t.Typ == "Inkomst").ToList(); // Filtrerar ut alla vinster

            float largestWin = winTransactions.Any() ? winTransactions.Max(t => t.Belopp) : 0; // Största vinsten, om inga vinster finns så sätts den till 0
            float totalLosses = transactions.Where(t => t.Kategori == "Sparande" && t.Typ == "Utgift").Sum(t => t.Belopp); // Totala förluster
            float totalWin = winTransactions.Sum(t => t.Belopp); // Totala vinster
            float totalResult = totalWin - totalLosses; // Beräknar totala resultatet av spelutmaningen
            return (largestWin, totalResult); // Returnerar största vinsten och de totala resultatet för spelaren
        }

    }
}
