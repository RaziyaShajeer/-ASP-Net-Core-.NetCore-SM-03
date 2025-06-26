using Microsoft.AspNetCore.Mvc;
using JobPortalAPI.Service;
using JobPortalAPI.DTOs;
using JobPortalAPI.Interface;

namespace JobPortalAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobsController : ControllerBase
    {
        private readonly IJobService _jobService;

        public JobsController(IJobService jobService)
        {
            _jobService = jobService;
        }

        [HttpGet]
        public async Task<IActionResult> GetJobs()
        {
            return Ok(await _jobService.GetJobsAsync());
        }

        [HttpPost]
        public async Task<IActionResult> AddJob([FromBody] JobDTO jobDto)
        {
            return Ok(await _jobService.AddJobAsync(jobDto));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateJob(int id, [FromBody] JobDTO jobDto)
        {
            var updatedJob = await _jobService.UpdateJobAsync(id, jobDto);
            if (updatedJob == null)
                return NotFound(new { message = "Job not found" });

            return Ok(updatedJob);
        }

        // Delete a job
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJob(int id)
        {
            var isDeleted = await _jobService.DeleteJobAsync(id);
            if (!isDeleted)
                return NotFound(new { message = "Job not found" });

            return NoContent();
        }
    }
}
