using System;
using System.Collections.Generic;
using System.Text;
using Projekt.Models;

namespace Projekt.Services
{
    public static class SessionService
    {
        public static User? CurrentUser { get; set; } // Den inloggade användaren
    }
}
