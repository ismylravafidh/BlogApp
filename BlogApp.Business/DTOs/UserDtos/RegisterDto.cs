using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BlogApp.Business.DTOs.UserDtos
{
    public class RegisterDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
    public class RegisterDtoValidation : AbstractValidator<RegisterDto>
    {
        public RegisterDtoValidation()
        {
            RuleFor(c => c.Name)
                .NotEmpty()
                .WithMessage("Name bos ola bilmez")
                .MaximumLength(30)
                .WithMessage("Name-in uzunlugu 30-dan cox ola bilmez");
            RuleFor(c => c.Surname)
                .NotEmpty()
                .WithMessage("Surname bos ola bilmez")
                .MaximumLength(30)
                .WithMessage("Surname-in uzunlugu 30-dan cox ola bilmez");
            RuleFor(c => c.UserName)
                .NotEmpty()
                .WithMessage("UserName bos ola bilmez")
                .MaximumLength(30)
                .WithMessage("UserName-in uzunlugu 30-dan cox ola bilmez");
            RuleFor(c => c.Email)
                .NotEmpty()
                .WithMessage("Email bos ola bilmez")
                .EmailAddress();
            RuleFor(c => c.Password)
                .NotEmpty()
                .WithMessage("Password bos ola bilmez")
                .Must(p =>
                {
                    Regex regex = new Regex(@"^(?=.*[A-Z]).{6,}$");
                    Match match = regex.Match(p);
                    return match.Success;
                });
            RuleFor(c => c)
                .Must(p => p.ConfirmPassword == p.Password)
                .WithMessage("Confirm Password Password ile eyni olmalidir");
        }
    }
}
