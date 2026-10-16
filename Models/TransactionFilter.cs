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
        public DateTime? fDatum { get; set; } // Från datum
        public DateTime? tDatum { get; set; } // Till datum
        
        public float? minBelopp { get; set; } // Minsta belopp

        public float? maxBelopp { get; set; } // Största belopp

        public string? sFras { get; set; } // Sökord

        // Initierar inga värden för filter, eftersom man ska kunna klicka på filtrera utan att behöva skicka med specifika värden
        public TransactionFilter()
        {
            Typ = null;
            //Namn = null;
            Kategori = [];
            fDatum = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            tDatum = null;
            minBelopp = null;
            maxBelopp = null;
            sFras = null;
        }
    }
}
