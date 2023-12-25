using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Business.Exceptions.Id
{
    public class IdNullException:Exception
    {
        public IdNullException() : base("Id Null Ola Bilmez") 
        {
        }
        public IdNullException(string message):base(message)
        {
        }
    }
}
