using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Business.Exceptions.Logo
{
    public class LogoSizeExceededException:Exception
    {
        public LogoSizeExceededException():base("Max 2 mb Yukluye Bilersiz")
        {
        }
        public LogoSizeExceededException(string message):base(message)
        {
        }
    }
}
