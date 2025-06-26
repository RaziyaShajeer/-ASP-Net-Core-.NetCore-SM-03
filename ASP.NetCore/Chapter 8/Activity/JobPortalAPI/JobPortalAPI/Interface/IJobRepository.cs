using JobPortalAPI.Model;

namespace JobPortalAPI.Interface
{
    public interface IJobRepository
    {
        Task<IEnumerable<Job>> GetJobsAsync();
        Task<Job> GetJobByIdAsync(int id);
        Task<Job> AddJobAsync(Job job);
        Task<Job> UpdateJobAsync(Job job);
        Task<bool> DeleteJobAsync(int id);
    }
}
