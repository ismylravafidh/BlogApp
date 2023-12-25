using FluentValidation;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Business.DTOs.CategoryDTOs
{
    public class CategoryCreateDto
    {
        public string? Name { get; set; }
        public IFormFile? Logo { get; set; }
    }
    public class CategoryCreateDtoValidation : AbstractValidator<CategoryCreateDto>
    {
        public CategoryCreateDtoValidation()
        {
            RuleFor(c => c.Name)
                .NotNull()
                .WithMessage("Category Name Bos Ola Bilmez.")
                .MaximumLength(64)
                .WithMessage("Category Name-nin Uzunlugu 64-den Cox Ola Bilmez.")
                .MinimumLength(3)
                .WithMessage("Category Name-nin Uzunlugu 3-den Az Ola Bilmez");
            RuleFor(c => c.Logo)
                .NotNull()
                .WithMessage("Logo Bos Ola Bilmez.");
        }
    }
}
