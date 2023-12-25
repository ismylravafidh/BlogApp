using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Business.Exceptions.Id
{
    public class IdNegativeException:Exception
    {
        public IdNegativeException():base("Id menfi ola bilmez")
        {
        }
        public IdNegativeException(string message) : base(message)
        {
        }
    }
}
