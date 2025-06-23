using System.Runtime.CompilerServices;
using AutoMapper;
using HospitalMgmt.Dto;
using HospitalMgmt.Interface;

namespace HospitalMgmt.Repository
{
    public class DoctorService:IDoctorService
    {
        private readonly IDoctorRepository _repository;
        private readonly IMapper _mapper;
        public DoctorService(IDoctorRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<DoctorDto>> GetAll()
        {
            var doctors=await _repository.GetAll();
            return _mapper.Map<IEnumerable<DoctorDto>>(doctors);
        }
        public async Task<IEnumerable<DoctorDto>> GetById(int id)
        {
            var doctors = await _repository.GetById(id);
            return _mapper.Map<DoctorDto>(doctors);
        }
        public async Task<DoctorDto>AddDoctors(DoctorDto doctorDto)
        {
            var doctors=_mapper.Map<DoctorDto>(doctorDto);
            var newDoctor = await _repository.AddDoctors(doctorDto);
            return _mapper.Map<DoctorDto>(newDoctor);
        


    }
}
