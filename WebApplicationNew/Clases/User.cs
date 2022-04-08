using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationNew.Clases
{
    public class User
    {
        private string _mail;
        private string _nombre;
        private string _password;
        public User(string mail, string nombre, string password)
        {
            _mail = mail;
            _nombre = nombre;
            _password = password;
        }

        public string mail
        {
            get
            {
                return _mail;
            }
        }
        public string nombre
        {
            get
            {
                return _nombre;
            }
        }
        public string password
        {
            get
            {
                return _password;
            }
        }
    }
}