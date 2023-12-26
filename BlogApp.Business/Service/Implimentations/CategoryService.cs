using AutoMapper;
using BlogApp.Business.DTOs.CategoryDTOs;
using BlogApp.Business.Exceptions.Category;
using BlogApp.Business.Exceptions.Id;
using BlogApp.Business.Exceptions.Logo;
using BlogApp.Business.Helpers;
using BlogApp.Business.Service.Interfaces;
using BlogApp.Core.Entities;
using BlogApp.DAL.Repository.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Business.Service.Implimentations
{
    public class CategoryService : ICategoryService
    {
        ICategoryRepository _repository;
        IMapper _mapper;
        string _env;
        public CategoryService(ICategoryRepository repository , IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
            _env = @"C:\Users\II novbe\source\repos\BlogApp\BlogApp.API\wwwroot\";
            
        }

        public async Task<IQueryable<Category>> GetAllAsync()
        {
            var categories = await _repository.GetAllAsync();
            if (categories is null)
            {
                throw new CategoryNotFoundException();
            }
            return categories;
        }
        public async Task<Category> GetByIdAsync(int id)
        {
            if(id == 0)
            {
                throw new IdZeroException();
            }
            if (id < 0)
            {
                throw new IdNegativeException();
            }
            Category category = await _repository.GetByIdAsync(id);
            if(category is null)
            {
                throw new CategoryNotFoundException();
            }
            return category;
        }
        public async Task Create(CategoryCreateDto entity)
        {
            if (entity is null)
            {
                throw new CategoryNullException();
            }
            if (!entity.Logo.ContentType.Contains("image"))
            {
                throw new LogoTypeException();
            }
            if (entity.Logo.Length > 2097152)
            {
                throw new LogoSizeExceededException();
            }
            Category category = _mapper.Map<Category>(entity);
            category.LogoUrl = entity.Logo.Upload(_env, @"\Upload\Logo\");
            await _repository.Create(category);
            await _repository.SaveChangesAsync();
        }
        public async Task Update(CategoryUpdateDto entity)
        {
            if (entity.Id == 0)
            {
                throw new IdZeroException();
            }
            if (entity.Id < 0)
            {
                throw new IdNegativeException();
            }
            Category oldCategory = await _repository.GetByIdAsync(entity.Id);
            if (oldCategory is null)
            {
                throw new CategoryNotFoundException();
            }
            if (entity.Logo != null)
            {
                
                FileManager.DeleteFile(oldCategory.LogoUrl,_env, @"\Upload\Logo\");
                if (!entity.Logo.ContentType.Contains("image"))
                {
                    throw new LogoTypeException();
                }
                if (entity.Logo.Length > 2097152)
                {
                    throw new LogoSizeExceededException();
                }
                entity.LogoUrl = entity.Logo.Upload(_env, @"\Upload\Logo\");
            }


            _mapper.Map(entity, oldCategory);
            await _repository.Update(oldCategory);
            await _repository.SaveChangesAsync();
        }
        public async void Delete(int id)
        {
            if (id == 0)
            {
                throw new IdZeroException();
            }
            if (id < 0)
            {
                throw new IdNegativeException();
            }
            Category category = await _repository.GetByIdAsync(id);
            if (category is null)
            {
                throw new CategoryNotFoundException();
            }
            _repository.Delete(category);
            await _repository.SaveChangesAsync();
        }

    }
}
