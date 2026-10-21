using System;
using System.Collections.Generic;
using System.Text;
using Projekt.Models;

namespace Projekt.Interfaces
{
    public interface IUserService
    {
        Task<bool> CreateUser(User user); // Lägger till en ny användare

        Task <User?> GetUser(string username); // Hämtar en befintlig användare
    }
}
