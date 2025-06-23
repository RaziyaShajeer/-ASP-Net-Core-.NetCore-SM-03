using HospitalMgmt.Dto;
using HospitalMgmt.Models;

namespace HospitalMgmt.Interface
{
    public interface IDoctorService
    {
        Task<IEnumerable<DoctorDto>> GetAll();
        Task<DoctorDto> GetById(int id);
        Task<DoctorDto> AddDoct(DoctorDto doctor);
        Task<DoctorDto> UpdateDoctor(DoctorDto doctor);
        Task<bool> DeleteDoctor(int id);
    }
}
