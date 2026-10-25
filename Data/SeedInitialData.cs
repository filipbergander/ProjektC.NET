using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Projekt.Models;
using Projekt.Data;
using Projekt.Authentication;

namespace Projekt.Data
{
    internal static class SeedInitialData
    {
        public static void SeedData(ProjektDbContext db)
        {
            // För att hasha lösenordet och skapa salt, -> dölja lösenordet i databasen
            string salt = PasswordAuthentication.GenerateSalt();
            if (!db.Users.Any())
            {
                User adminUser = new User
                {
                    Username = "Miun",
                    Role = "Admin",
                    Salt = salt,
                    PasswordHash = PasswordAuthentication.HashPassword("rootroot123!", salt)
                };
                db.Users.Add(adminUser);
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
                    Datum = "2026-11-01"
                },
                new Transaction
                {
                    Typ = "Inkomst",
                    Namn = "Sålde bil",
                    Kategori = "Bil",
                    Belopp = 3000,
                    Datum = "2026-10-01"
                },
                    new Transaction
                    {
                        Typ = "Utgift",
                        Namn = "Hyra",
                        Kategori = "Hyra",
                        Belopp = 10000,
                        Datum = "2026-10-01"
                    },
                        new Transaction
                        {
                            Typ = "Utgift",
                            Namn = "Handlade på ICA",
                            Kategori = "Mat",
                            Belopp = 1500,
                            Datum = "2026-10-01"
                        },
                        new Transaction
                        {
                            Typ = "Utgift",
                            Namn = "Mobilabonnemang",
                            Kategori = "Räkningar",
                            Belopp = 250,
                            Datum = "2026-10-01"
                        },
                            new Transaction
                            {
                                Typ = "Utgift",
                                Namn = "Köpte ny bil",
                                Kategori = "Bil",
                                Belopp = 15000,
                                Datum = "2026-10-01"
                            }
                );
            }
            db.SaveChanges();
        }
    }
}
