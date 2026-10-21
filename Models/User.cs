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
        public string? Password { get; set; }
        public string? SaltedHashPassword { get; set; }
        public User()
        {

        }

        public User(string username, string role, string password)
        {
            Username = username;
            Role = role;
            Password = password;
        }
    }

}
