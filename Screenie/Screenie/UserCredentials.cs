using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Screenie
{
    class UserCredentials
    {
        private string _username;
        private string _password;

        public UserCredentials(string username, string password) 
        {
            _username = username;
            _password = password;
        }

        public string Username
        {
            get { return _username; }
        }


        public string Password
        {
            get { return _password; }
        }

    }
}
