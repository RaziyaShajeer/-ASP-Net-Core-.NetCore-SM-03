using AutoMapper;
using HospitalMgmt.Dto;
using HospitalMgmt.Models;

namespace HospitalMgmt.Helper
{
    public class MappingProfile:Profile
    {
        public MappingProfile() { 
            CreateMap<Doctors,DoctorDto>().ReverseMap();
            CreateMap<>().ReverseMap();


        }
    }
}
