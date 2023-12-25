using BlogApp.Core.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Business.DTOs.CategoryDTOs
{
    public class CategoryGetAllDto
    {
        public int CategoryId { get; set; }
        public IQueryable<Category> Categories { get; set; }
    }
}
