using AutoMapper;
using BlogApp.Business.DTOs.UserDtos;
using BlogApp.Business.Exceptions.Login;
using BlogApp.Business.Exceptions.Register;
using BlogApp.Business.ExternalServices.Interfaces;
using BlogApp.Business.Service.Interfaces;
using BlogApp.Core.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Business.Service.Implimentations
{
    public class UserService : IUserService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IMapper _mapper;
        private readonly ITokenService _tokenService;

        public UserService(UserManager<AppUser> userManager ,IMapper mapper,ITokenService tokenService)
        {
            _userManager = userManager;
            _mapper = mapper;
            _tokenService = tokenService;
        }
        public async Task Register(RegisterDto registerDto)
        {
            AppUser user = _mapper.Map<AppUser>(registerDto);
            var result = await _userManager.CreateAsync(user,registerDto.Password);
            if (!result.Succeeded)
            {
                throw new RegisterException();
            }
        }

        public async Task<TokenDto> Login(LoginDto loginDto)
        {
            var user = await _userManager.FindByEmailAsync(loginDto.UserNameOrEmail)??await _userManager.FindByNameAsync(loginDto.UserNameOrEmail);

            if (user == null) throw new LoginNotFoundException();

            if(!await _userManager.CheckPasswordAsync(user , loginDto.Password)) throw new LoginNotFoundException();

            return _tokenService.CreateToken(user);
        }

    }
}
