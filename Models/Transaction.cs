using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Projekt.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        // Skriver på svenska eftersom det blir kolumnernas namn i transaktions-formuläret & databasen
        public string? Typ { get; set; }
        public string? Namn { get; set; }
        public string? Kategori { get; set; }
        public float Belopp { get; set; }
        public string? Datum { get; set; }

        public Transaction(string? typ, string? namn, string? kategori, float belopp, string? datum)
        {
            Typ = typ;
            Namn = namn;
            Kategori = kategori;
            Belopp = belopp;
            Datum = datum;
        }
    }
}
