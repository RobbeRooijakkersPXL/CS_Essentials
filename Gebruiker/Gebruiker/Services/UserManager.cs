using Gebruiker.Models;
using Gebruiker.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Gebruiker.Services
{
    public class UserManager
    {
        

        private string _username;
        private string _passwordHash;

        


        public void Register(string username, string password)
        {
            _username = username;
            _passwordHash = HashPassword(password);
           
        }

        public bool TryLogin(Login credentials)
        {
            if(!credentials.Username.Equals(_username, StringComparison.CurrentCultureIgnoreCase)) 
            {
                
                return false;

            }

            string hash = HashPassword(credentials.Password);

            if (!hash.Equals(_passwordHash))
            {
                return false;
            }

            return true;
        }

        private string HashPassword(string password)
        {
            using (var sha = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hash = sha.ComputeHash(bytes);
                return Convert.ToBase64String(hash);
            }
        }

        public void ShowHash() {
            Console.WriteLine($"Hash: {_passwordHash}");
        }
    }
}
