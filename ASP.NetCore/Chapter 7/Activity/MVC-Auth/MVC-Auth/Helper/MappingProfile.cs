using AutoMapper;
using MVC_Auth.Dto;
using MVC_Auth.Models;

namespace MVC_Auth.Helper
{
    public class MappingProfile:Profile
    {
        public MappingProfile() 
        {
            CreateMap<User, UseDto>().ReverseMap();
        }
    }
}
