using System;
using System.Collections.Generic;
using System.Text;
using Projekt.Forms;
using Projekt.Models;
using Microsoft.EntityFrameworkCore;
using Projekt.Data;
using System.Runtime.InteropServices.Marshalling;
using Projekt.Interfaces;
using System.Data.Common;
using Projekt.Authentication;

namespace Projekt.Services
{
    public class UserService : IUserService
    {
        private readonly ProjektDbContext database;
        public UserService()
        {
            database = new ProjektDbContext();
            database.Database.EnsureCreated();
            SeedInitialData.SeedData(database);
        }
        // Lägger till en ny användare i databasen
        public async Task<bool> CreateUser(User user)
        {
            // Kollar om användaren redan finns i databasen
            var existingUser = await database.Set<User>()
                .AnyAsync(existingUser => existingUser.Username == user.Username);

            if (existingUser)
            {
                return false;
            }
            // Skapar salt och hashar lösenordet med saltet
            string salt = PasswordAuthentication.GenerateSalt();
            string passwordHash = PasswordAuthentication.HashPassword(user.PasswordHash!, salt);

            // Skapar ny användare utifrån inmatning samt salt och hashen
            User createNewUser = new User
            {
                Username = user.Username,
                Role = user.Role,
                Salt = salt,
                PasswordHash = passwordHash
            };

            // Lägger till användaren i databasen och sparar
            database.Set<User>().Add(createNewUser);
            await database.SaveChangesAsync();

            return true;
        }

        // Hämtar in en användare från databasen genom användarnamnet
        public async Task<User?> GetUser(string username) => await database.Users.FirstOrDefaultAsync(u => u.Username == username);
        // Autentiserar en användare genom att hitta användaren i databasen genom användarnamnet, och jämför hashen med det inmatade lösenordet
        public async Task<bool> AuthenticateUser(string username, string password)
        {
            var user = await database.Users.FirstOrDefaultAsync(u => u.Username == username); // Försöker hämta användare från databas
            if (user == null)
            {
                return false;
            }
            // Hashar det inmatade lösenordet med salt och jämför med hashen i databasen
            string loginHash = PasswordAuthentication.HashPassword(password, user.Salt!);
            return loginHash == user.PasswordHash;
        }
    }

}
