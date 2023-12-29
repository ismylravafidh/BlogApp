using BlogApp.Business.DTOs.UserDtos;
using BlogApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Business.ExternalServices.Interfaces
{
    public interface ITokenService
    {
        TokenDto CreateToken(AppUser user,int expireDate=120);
    }
}
