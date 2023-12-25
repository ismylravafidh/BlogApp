using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Business.Exceptions.Id
{
    public class IdZeroException:Exception
    {
        public IdZeroException() : base("Id 0 ola bilmez")
        {
        }
        public IdZeroException(string message) : base(message)
        {
        }
    }
}
