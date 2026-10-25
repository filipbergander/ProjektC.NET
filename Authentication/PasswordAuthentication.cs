using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Projekt.Authentication
{
    internal class PasswordAuthentication
    {
        // En random salt-sträng skapas när användaren registreras
        public static string GenerateSalt()
        {
            var rng = RandomNumberGenerator.Create();
            byte[] saltBytes = new byte[16];
            rng.GetBytes(saltBytes);
            string saltText = Convert.ToBase64String(saltBytes);
            return saltText;
        }
        // Lösenordet hashas genom saltet
        public static string HashPassword(string password, string salt)
        {
            var sha = SHA256.Create();
            string saltedPassword = password + salt;
            byte[] hashBytes = sha.ComputeHash(Encoding.UTF8.GetBytes(saltedPassword));
            string hashText = Convert.ToBase64String(hashBytes);
            return hashText;
        }
    }
}
