using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Projekt.Models;
using Projekt.Services;

namespace Projekt.Data
{
    internal static class SeedInitialData
    {
        public static void SeedData(ProjektDbContext db)
        {
            User adminUser;
            // För att hasha lösenordet och skapa salt, -> dölja lösenordet i databasen
            string salt = PasswordHash.GenerateSalt();
            if (!db.Users.Any())
            {
                adminUser = new User
                {
                    Username = "Miun",
                    Role = "Admin",
                    Salt = salt,
                    PasswordHash = PasswordHash.HashPassword("rootroot123!", salt)
                };
                // Lägger till användaren i databasen och sparar
                db.Users.Add(adminUser);
                db.SaveChanges();
            }
            else
            {
                adminUser = db.Users.First();
            }

            // Om inga transaktioner finns i databasen, läggs det till några transaktioner
            if (!db.Transactions.Any())
            {
                db.Transactions.AddRange(new Transaction
                {
                    Typ = "Inkomst",
                    Namn = "Försvarsmakten",
                    Kategori = "Lön",
                    Belopp = 25000,
                    Datum = "2026-11-01",
                    UserId = adminUser.Id
                },
                new Transaction
                {
                    Typ = "Inkomst",
                    Namn = "Sålde bil",
                    Kategori = "Bil",
                    Belopp = 3000,
                    Datum = "2026-10-01",
                    UserId = adminUser.Id
                },
                    new Transaction
                    {
                        Typ = "Utgift",
                        Namn = "Hyra",
                        Kategori = "Hyra",
                        Belopp = 10000,
                        Datum = "2026-10-01",
                        UserId = adminUser.Id
                    },
                        new Transaction
                        {
                            Typ = "Utgift",
                            Namn = "Handlade på ICA",
                            Kategori = "Mat",
                            Belopp = 1500,
                            Datum = "2026-10-01",
                            UserId = adminUser.Id
                        },
                        new Transaction
                        {
                            Typ = "Utgift",
                            Namn = "Mobilabonnemang",
                            Kategori = "Räkningar",
                            Belopp = 250,
                            Datum = "2026-10-01",
                            UserId = adminUser.Id
                        },
                            new Transaction
                            {
                                Typ = "Utgift",
                                Namn = "Köpte ny bil",
                                Kategori = "Bil",
                                Belopp = 15000,
                                Datum = "2026-10-01",
                                UserId = adminUser.Id
                            }
                );
            }
            db.SaveChanges();
        }
    }
}
