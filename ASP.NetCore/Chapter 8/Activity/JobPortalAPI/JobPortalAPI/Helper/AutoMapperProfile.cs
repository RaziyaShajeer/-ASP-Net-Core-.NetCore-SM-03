using AutoMapper;
using JobPortalAPI.DTOs;
using JobPortalAPI.Model;

namespace JobPortalAPI.Helper
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Job, JobDTO>().ReverseMap();
            CreateMap<User, UserDTO>().ReverseMap();
        }
    }
}
