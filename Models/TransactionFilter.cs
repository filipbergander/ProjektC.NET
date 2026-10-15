using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt.Models
{
    internal class TransactionFilter
    {
        public string? Typ { get; set; }
        //public string? Namn { get; set; }
        public List<string> Kategori { get; set; } 
        public DateTime? fDate { get; set; } // Från datum
        public DateTime? tDate { get; set; } // Till datum

        //public string? sTerm { get; set; } // Sökord

        // Initierar inga värden för filter, eftersom man ska kunna klicka på filtrera utan att behöva skicka med specifika värden
        public TransactionFilter()
        {
            Typ = null;
            //Namn = null;
            Kategori = [];
            fDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            tDate = null;
            //sTerm = null;
        }
    }
}
