using System;
using System.Collections.Generic;
using System.Text;
using Projekt.Models;

namespace Projekt.Interfaces
{
    // Interface för UserService
    public interface IUserService
    {
        Task<bool> CreateUser(User user); // Lägger till en ny användare

        Task<User?> GetUser(string username); // Hämtar en befintlig användare

        Task<User?> AuthenticateUser(string username, string password); // Autentiserar en användare
    }
}
