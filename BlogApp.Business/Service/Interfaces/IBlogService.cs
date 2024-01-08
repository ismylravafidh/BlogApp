using BlogApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Business.Service.Interfaces
{
    public interface IBlogService
    {
        Task<IQueryable<Blog>> GetAllAsync();
    }
}
