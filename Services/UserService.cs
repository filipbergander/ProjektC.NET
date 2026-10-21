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
            // Lägger till användaren i databasen och sparar
            database.Set<User>().Add(user);
            await database.SaveChangesAsync();

            return true;
        }

        public async Task<User?> GetUser(string username) => await database.Users.FirstOrDefaultAsync(u => u.Username == username);
    }

}
