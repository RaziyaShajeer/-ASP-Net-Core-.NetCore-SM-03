using Microsoft.AspNetCore.Mvc;
using JobPortal_Activity.Interface;
using JobPortal_Activity.Dto;

public class JobsController : Controller
{
    private readonly IJobService _jobService;

    public JobsController(IJobService jobService)
    {
        _jobService = jobService;
    }

    // GET: Jobs (List all jobs)
    public async Task<IActionResult> Index()
    {
        var jobs = await _jobService.GetAllJobs();
        return View(jobs);
    }

    // GET: Jobs/Details/5
    public async Task<IActionResult> Details(int id)
    {
        var job = await _jobService.GetJobById(id);
        if (job == null) return NotFound();
        return View(job);
    }

    // GET: Jobs/Create (Show job creation form)
    public IActionResult Create()
    {
        return View();
    }

    // POST: Jobs/Create (Submit job creation form)
    /*[ValidateAntiForgeryToken] is an attribute in ASP.NET Core that helps
      protect your application against Cross-Site Request Forgery (CSRF) attacks.
      It ensures that requests to the action method come from a trusted source by 
      requiring a valid anti-forgery token.*/
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(JobDto jobDto)
    {
        if (!ModelState.IsValid) return View(jobDto);
        await _jobService.AddJob(jobDto);
        return RedirectToAction(nameof(Index));
       // return RedirectToAction("Index", "Jobs");
    }

    // GET: Jobs/Edit/5 (Show job edit form)
    public async Task<IActionResult> Edit(int id)
    {
        var job = await _jobService.GetJobById(id);
        if (job == null) return NotFound();
        return View(job);
    }

    // POST: Jobs/Edit/5 (Submit job edit form)
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, JobDto jobDto)
    {
        if (id != jobDto.Id) return BadRequest();
        if (!ModelState.IsValid) return View(jobDto);
        await _jobService.UpdateJob(jobDto);
        return RedirectToAction(nameof(Index));
    }

    // GET: Jobs/Delete/5 (Show delete confirmation page)
    public async Task<IActionResult> Delete(int id)
    {
        var job = await _jobService.GetJobById(id);
        if (job == null) return NotFound();
        return View(job);
    }

    // POST: Jobs/Delete/5 (Confirm delete action)
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _jobService.DeleteJob(id);
        return RedirectToAction(nameof(Index));
    }
}
