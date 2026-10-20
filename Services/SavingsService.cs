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
    public class SavingsService
    {
        // Instans av Transactionsservicen
        private readonly ITransactionService transaction;

        public SavingsService(ITransactionService transaction)
        {
            this.transaction = transaction;
        }
        /// <summary>
        /// Räknar ut hur mycket pengar man kommer ha efter ett visst antal år, med startbelopp, avsättning per månad och årlig ränta.   
        /// </summary>
        /// <param name="startAmount"> Startbelopp av pengar</param>
        /// <param name="monthlyInvest"> Hur mycket pengar som avsätts varje månad</param>
        /// <param name="annualInterestRate">Årliga räntan</param>
        /// <param name="years"> Antal år som man vill spara</param>
        /// <returns> Det totala beloppet efter angivet antal år</returns>
        public decimal CalculateFutureSavings(decimal startAmount, decimal monthlyInvest, double annualInterestRate, int years)
        {
            double monthlyRate = annualInterestRate / 12; // Ränta per månad, t.ex om förväntad ränta per år för avkastningen är 6% så är månadsräntan: 0.5%
            int totalMonths = years * 12; // Totalt antal månader

            decimal totalAmount = startAmount; // Totala beloppet börjar med startbeloppet, t.ex att man börjar på 5000 kr

            for (int i = 0; i < totalMonths; i++)
            {
                // Lägger till hur mycket man vill avsätta varje månad, t.ex 500 kr
                totalAmount += monthlyInvest;

                totalAmount *= (decimal)(1 + monthlyRate); // Lägger till räntan på det totala beloppet, t.ex 0.5% per månad
            }
            // Det totala beloppet avrundat med två decimaler
            return Math.Round(totalAmount, 2);
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
    }
}
