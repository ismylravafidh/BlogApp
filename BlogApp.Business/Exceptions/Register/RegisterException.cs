using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Business.Exceptions.Register
{
    public class RegisterException : Exception
    {
        public RegisterException() : base("Register Zamani Xeta Bas Verdi")
        {
        }
        public RegisterException(string message) : base(message)
        {
        }
    }
}
