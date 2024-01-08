using AutoMapper;
using BlogApp.Business.Exceptions.Category;
using BlogApp.Business.Service.Interfaces;
using BlogApp.Core.Entities;
using BlogApp.DAL.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Business.Service.Implimentations
{
    public class BlogService : IBlogService
    {
        IBlogRepository _repository;
        IMapper _mapper;
        string _env;
        public BlogService(IBlogRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
            _env = @"C:\Users\II novbe\source\repos\BlogApp\BlogApp.API\wwwroot\";

        }

        public async Task<IQueryable<Blog>> GetAllAsync()
        {
            IQueryable<Blog> blog = await _repository.GetAllAsync();
            return blog;
        }
    }
}
