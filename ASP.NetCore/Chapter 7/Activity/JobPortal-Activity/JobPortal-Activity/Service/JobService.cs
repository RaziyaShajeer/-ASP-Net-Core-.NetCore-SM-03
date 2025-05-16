using AutoMapper;
using JobPortal_Activity.Dto;
using JobPortal_Activity.Interface;
using JobPortal_Activity.Models;

public class JobService : IJobService
{
    private readonly IJobRepository _repository;
    private readonly IMapper _mapper;

    public JobService(IJobRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<JobDto>> GetAllJobs()
    {
        var jobs = await _repository.GetAllJobs();
        return _mapper.Map<IEnumerable<JobDto>>(jobs);
    }

    public async Task<JobDto> GetJobById(int id)
    {
        var job = await _repository.GetJobById(id);
        return _mapper.Map<JobDto>(job);
    }

    public async Task<JobDto> AddJob(JobDto jobDto)
    {
        var job = _mapper.Map<Job>(jobDto);
        var newJob = await _repository.AddJob(job);
        return _mapper.Map<JobDto>(newJob);
    }

    public async Task<JobDto> UpdateJob(JobDto jobDto)
    {
        var job = _mapper.Map<Job>(jobDto);
        var updatedJob = await _repository.UpdateJob(job);
        return _mapper.Map<JobDto>(updatedJob);
    }

    public async Task<bool> DeleteJob(int id) => await _repository.DeleteJob(id);
}
