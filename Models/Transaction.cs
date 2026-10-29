using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Projekt.Models
{
    public class Transaction
    {        // Skriver på svenska eftersom det blir kolumnernas namn i transaktions-formuläret & databasen
        public int Id { get; set; }

        public string? Typ { get; set; }
        public string? Namn { get; set; }
        public string? Kategori { get; set; }
        public float Belopp { get; set; }
        public string? Datum { get; set; }
        public int UserId { get; set; } // Främmande nyckel mot användartabellen
        public User User { get; set; } = null!; 

        // Konstruktorer
        public Transaction() // Tom konstruktor som används när man skapar seedningsdata
        {
        }

        public Transaction(string typ, string namn, string kategori, float belopp, string datum, int userId)
        {
            Typ = typ;
            Namn = namn;
            Kategori = kategori;
            Belopp = belopp;
            Datum = datum;
            UserId = userId;
        }
    }
}
