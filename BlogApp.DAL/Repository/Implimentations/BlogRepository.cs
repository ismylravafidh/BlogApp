using BlogApp.Core.Entities;
using BlogApp.DAL.Context;
using BlogApp.DAL.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.DAL.Repository.Implimentations
{
    public class BlogRepository : Repository<Blog>, IBlogRepository
    {
        public BlogRepository(BlogAppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
