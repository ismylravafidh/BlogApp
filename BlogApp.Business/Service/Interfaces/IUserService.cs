using BlogApp.Business.DTOs.UserDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Business.Service.Interfaces
{
    public interface IUserService
    {
        Task Register(RegisterDto registerDto);
        Task<TokenDto> Login(LoginDto loginDto);
    }
}
