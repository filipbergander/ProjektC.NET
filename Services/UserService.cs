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
    // Implementerar interfacet för att kunna hantera användare i databasen
    public class UserService : IUserService
    {
        // Instans
        private readonly ProjektDbContext database;

        // Konstruktor
        public UserService()
        {
            database = new ProjektDbContext();
            database.Database.EnsureCreated();
            SeedInitialData.SeedData(database); // Fyller på med data initialt om databasen är tom vid start
        }
        // Lägger till en ny användare i databasen
        public async Task<bool> CreateUser(User user)
        {
            // Kollar om användaren redan finns i databasen
            var existingUser = await database.Set<User>()
                .AnyAsync(existingUser => existingUser.Username == user.Username);
            // Finns användaren redan?
            if (existingUser)
            {
                return false;
            }
            // Skapar salt och hashar lösenordet med saltet
            string salt = PasswordHash.GenerateSalt();
            string passwordHash = PasswordHash.HashPassword(user.PasswordHash!, salt);

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
        public async Task<User?> AuthenticateUser(string username, string password)
        {
            // Försöker hämta användare från databas
            var user = await database.Users.FirstOrDefaultAsync(u => u.Username == username);
            if (user == null)
            {
                return null;
            }
            // Hashar det inmatade lösenordet med salt och jämför med hashen i databasen
            string loginHash = PasswordHash.HashPassword(password, user.Salt!);
            if (loginHash == user.PasswordHash)
            {
                return user;
            }
            return null;
        }
    }

}
