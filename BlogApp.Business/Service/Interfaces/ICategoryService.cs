using BlogApp.Business.DTOs.CategoryDTOs;
using BlogApp.Core.Entities;
using BlogApp.DAL.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Business.Service.Interfaces
{
    public interface ICategoryService
    {
        Task<IQueryable<Category>> GetAllAsync();
        Task<Category> GetByIdAsync(int id);
        Task Create(CategoryCreateDto entity);
        Task Update(CategoryUpdateDto entity);
        void Delete(int id);
    }
}
