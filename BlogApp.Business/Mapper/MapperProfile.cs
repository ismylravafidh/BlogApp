using AutoMapper;
using BlogApp.Business.DTOs.CategoryDTOs;
using BlogApp.Business.DTOs.UserDtos;
using BlogApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Business.Mapper
{
    public class MapperProfile:Profile
    {
        public MapperProfile()
        {
            CreateMap<Category,CategoryCreateDto>();
            CreateMap<CategoryCreateDto,Category>();


            CreateMap<RegisterDto,AppUser>();
            CreateMap<RegisterDto,AppUser>().ReverseMap();
        }
    }
}
