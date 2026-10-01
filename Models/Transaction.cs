using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class Transaction
    {
        public Guid Id { get; set; }
        public string? Type { get; set; }
        public string? Title { get; set; }
        public string? Category { get; set; }
        public float Amount { get; set; }
        public string? Date { get; set; }

        public Transaction(string? type, string? title, string? category, float amount)
        {
            Id = Guid.NewGuid();
            Type = type;
            Title = title;
            Category = category;
            Amount = amount;
            Date = DateTime.Now.ToString("yyyy-MM-dd");
        }
    }
}
