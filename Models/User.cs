using System;
using System.Collections.Generic;
using System.Text;
using Projekt.Forms;

namespace Projekt.Models
{
    public class User
    {
        public int Id { get; set; }
        public string? Username { get; set; }
        public string? Role { get; set; }
        public string? Salt { get; set; }
        public string? PasswordHash { get; set; }
        public User()
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
