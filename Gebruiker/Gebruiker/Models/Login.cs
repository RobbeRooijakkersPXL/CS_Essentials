using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gebruiker.Models
{
    public class Login
    {
        

        private string _password;

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        private string _username;

        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

    }
    

        


    
}
