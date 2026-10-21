using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using Projekt.Models;

namespace Projekt.Data
{
    internal class ProjektDbContext : DbContext
    {
        public DbSet<Transaction> Transactions => Set<Transaction>();

        public DbSet<User> Users => Set<User>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Skapar databasfilen i bin-filen samma som där applikationen körs från
            string dbPath = Path.Combine(AppContext.BaseDirectory, "budget-app.db");
            optionsBuilder.UseSqlite($"Data Source={dbPath}")
     .LogTo(
                action: message =>
                {
                    // Filtrera bort EF:s interna migreringstabeller så bara verklig SQL syns
                    if (message.Contains("__EFMigrations") || message.Contains("PRAGMA"))
                        return;

                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("\n┌── [SQL TILL DATABASEN] ───────────────────────────");
                    Console.WriteLine(message.TrimEnd());
                    Console.WriteLine("└───────────────────────────────────────────────────");
                    Console.ResetColor();
                },
                categories: [DbLoggerCategory.Database.Command.Name],
                minimumLevel: LogLevel.Information
            )
            .EnableSensitiveDataLogging();
        }


    }
}
