using JobPortalAPI.DTOs;

namespace JobPortalAPI.Interface
{
    public interface IJobService
    {
        Task<IEnumerable<JobDTO>> GetJobsAsync();
        Task<JobDTO> GetJobByIdAsync(int id);
        Task<JobDTO> AddJobAsync(JobDTO jobDto);
        Task<JobDTO> UpdateJobAsync(int id, JobDTO jobDto);
        Task<bool> DeleteJobAsync(int id);
    }
}
