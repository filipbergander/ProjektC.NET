using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt.Models
{
    public class Transaction
    {
        public Guid Id { get; set; }
        public string? Typ { get; set; }
        public string? Namn { get; set; }
        public string? Kategori { get; set; }
        public float Belopp { get; set; }
        public string? Datum { get; set; }

        public Transaction(string? typ, string? namn, string? kategori, float belopp)
        {
            Id = Guid.NewGuid();
            Typ = typ;
            Namn = namn;
            Kategori = kategori;
            Belopp = belopp;
            Datum = DateTime.Now.ToString("yyyy-MM-dd");
        
        }
    }
}
