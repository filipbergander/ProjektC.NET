using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public required string? Type { get; set; }
        public required string? Title { get; set; }
        public string? Category { get; set; }
        public float Amount { get; set; }
        public string? Date { get; set; } = DateTime.Now.ToString();
    }
}
