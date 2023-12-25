using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Business.Exceptions.Category
{
    internal class CategoryNotFoundException:Exception
    {
        public CategoryNotFoundException():base("Data Tapilmadi.")
        {
        }
        public CategoryNotFoundException(string message):base(message)
        {
        }
    }
}
