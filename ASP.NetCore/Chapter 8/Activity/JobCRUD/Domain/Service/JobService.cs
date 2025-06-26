using AutoMapper;
using Domain.DTOs;
using Domain.Interface;
using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service
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

        public async Task<IEnumerable<JobDTO>> GetAllJobsAsync()
        {
            var jobs = await _jobRepository.GetAllJobsAsync();
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

        public async Task<JobDTO> UpdateJobAsync(JobDTO jobDto)
        {
            var job = _mapper.Map<Job>(jobDto);
            job = await _jobRepository.UpdateJobAsync(job);
            return _mapper.Map<JobDTO>(job);
        }

        public async Task<bool> DeleteJobAsync(int id)
        {
            return await _jobRepository.DeleteJobAsync(id);
        }
    }
}
