using System;
using System.Collections.Generic;
using System.Text;
using Projekt.Forms;

namespace Projekt.Models
{
    // Användare i applikationen
    public class User
    {
        public int Id { get; set; }
        public string? Username { get; set; }
        public string? Role { get; set; }
        public string? Salt { get; set; }
        public string? PasswordHash { get; set; }
        public List<Transaction> Transactions { get; set; } = [];

        public User() // Tom konstruktor som används när man skapar seedningsdata
        {

        }

        public User(string username, string role, string passwordHash)
        {
            Username = username;
            Role = role;
            PasswordHash = passwordHash;
        }
    }

}
