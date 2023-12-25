using FluentValidation;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Business.DTOs.CategoryDTOs
{
    public class CategoryUpdateDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? LogoUrl { get; set; }
        public IFormFile? Logo { get; set; }
    }
    public class CategoryUpdateDtoValidation : AbstractValidator<CategoryUpdateDto>
    {
        public CategoryUpdateDtoValidation()
        {
            RuleFor(c => c.Name)
                .MaximumLength(64)
                .WithMessage("Category Name-nin Uzunlugu 64-den Cox Ola Bilmez.")
                .MinimumLength(3)
                .WithMessage("Category Name-nin Uzunlugu 3-den Az Ola Bilmez");
        }
    }
}
