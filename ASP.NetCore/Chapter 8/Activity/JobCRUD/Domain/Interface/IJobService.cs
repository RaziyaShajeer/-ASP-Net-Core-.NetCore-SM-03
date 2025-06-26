using Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface
{
    public interface IJobService
    {
        Task<IEnumerable<JobDTO>> GetAllJobsAsync();
        Task<JobDTO> GetJobByIdAsync(int id);
        Task<JobDTO> AddJobAsync(JobDTO jobDto);
        Task<JobDTO> UpdateJobAsync(JobDTO jobDto);
        Task<bool> DeleteJobAsync(int id);
    }
}
