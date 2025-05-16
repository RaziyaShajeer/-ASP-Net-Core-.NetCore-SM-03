using JobPortal_Activity.Models;

namespace JobPortal_Activity.Interface
{
    public interface IJobRepository
    {
        Task<IEnumerable<Job>> GetAllJobs();
        Task<Job> GetJobById(int id);
        Task<Job> AddJob(Job job);
        Task<Job> UpdateJob(Job job);
        Task<bool> DeleteJob(int id);
    }
}
