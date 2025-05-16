using AutoMapper;
using JobPortal_Activity.Dto;
using JobPortal_Activity.Models;

namespace JobPortal_Activity.Helpers
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Job, JobDto>().ReverseMap();
        }
    }
}
