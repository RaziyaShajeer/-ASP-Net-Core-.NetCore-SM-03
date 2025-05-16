using Microsoft.EntityFrameworkCore;

using JobPortal_Activity.Interface;
using JobPortal_Activity.Models;

public class JobRepository : IJobRepository
{
    private readonly JobAppDbContext _context;

    public JobRepository(JobAppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Job>> GetAllJobs() => await _context.Jobs.ToListAsync();

    public async Task<Job> GetJobById(int id) => await _context.Jobs.FindAsync(id);

    public async Task<Job> AddJob(Job job)
    {
        _context.Jobs.Add(job);
        await _context.SaveChangesAsync();
        return job;
    }

    public async Task<Job> UpdateJob(Job job)
    {
        _context.Jobs.Update(job);
        await _context.SaveChangesAsync();
        return job;
    }

    public async Task<bool> DeleteJob(int id)
    {
        var job = await _context.Jobs.FindAsync(id);
        if (job == null) return false;
        _context.Jobs.Remove(job);
        await _context.SaveChangesAsync();
        return true;
    }
}
