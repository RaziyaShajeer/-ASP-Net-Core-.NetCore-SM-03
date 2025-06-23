using HospitalMgmt.Models;

namespace HospitalMgmt.Interface
{
    public interface IDoctorRepository
    {
        Task<IEnumerable<Doctors>> GetAll();
        Task<Doctors> GetById(int id);
        Task<Doctors> AddDoctor(Doctors doctor);
        Task<Doctors> UpdateDoctor(Doctors doctor);
        Task<Doctors> DeleteDoctor(int id);

    }
}
