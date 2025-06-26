using AutoMapper;
using JobPortalAPI.DTOs;
using JobPortalAPI.Interface;
using JobPortalAPI.Model;

namespace JobPortalAPI.Service
{
    public class JobService:IJobService
    {
        private readonly IJobRepository _jobRepository;
        private readonly IMapper _mapper;

        public JobService(IJobRepository jobRepository, IMapper mapper)
        {
            _jobRepository = jobRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<JobDTO>> GetJobsAsync()
        {
            var jobs = await _jobRepository.GetJobsAsync();
            return _mapper.Map<IEnumerable<JobDTO>>(jobs);
        }

        public async Task<JobDTO> GetJobByIdAsync(int id)
        {
            var job = await _jobRepository.GetJobByIdAsync(id);
            return _mapper.Map<JobDTO>(job);
        }

        public async Task<JobDTO> AddJobAsync(JobDTO jobDto)
        {
            var job = _mapper.Map<Job>(jobDto);
            job = await _jobRepository.AddJobAsync(job);
            return _mapper.Map<JobDTO>(job);
        }

        public async Task<JobDTO> UpdateJobAsync(int id, JobDTO jobDto)
        {
            var job = await _jobRepository.GetJobByIdAsync(id);
            if (job == null) return null;

            _mapper.Map(jobDto, job);
            await _jobRepository.UpdateJobAsync(job);
            return _mapper.Map<JobDTO>(job);
        }

        public async Task<bool> DeleteJobAsync(int id)
        {
            return await _jobRepository.DeleteJobAsync(id);
        }
    }
}
