using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Projekt.Models;
using Projekt.Data;

namespace Projekt.Data
{
    internal static class SeedInitialData
    {
        public static void SeedData(ProjektDbContext db)
        {
            if (!db.Users.Any())
            {
                var adminUser = new User
                {
                    Username = "AdminMiun",
                    Role = "Lärare",
                    HashPassword = "rootroot123!"
                };

                db.Users.Add(adminUser);
            }
            if (!db.Transactions.Any())
            {
                db.Transactions.AddRange(new Transaction
                {
                    Typ = "Inkomst",
                    Namn = "Jobbet",
                    Kategori = "Lön",
                    Belopp = 25000,
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
                            Belopp = 1500.0f,
                            Datum = "2026-10-01"
                        },
                        new Transaction
                        {
                            Typ = "Utgift",
                            Namn = "Mobilabonnemang",
                            Kategori = "Räkningar",
                            Belopp = 250,
                            Datum = "2026-10-01"
                        }
                );
            }
            db.SaveChanges();
        }
    }
}
