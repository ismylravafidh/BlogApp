using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Business.Exceptions.Login
{
    public class LoginNotFoundException : Exception
    {
        public LoginNotFoundException() : base("Username/Email or Password yanlisdir")
        {
        }

        public LoginNotFoundException(string? message) : base(message)
        {
        }
    }
}
