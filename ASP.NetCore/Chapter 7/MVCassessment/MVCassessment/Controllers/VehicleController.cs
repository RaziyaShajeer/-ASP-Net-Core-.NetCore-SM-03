using Microsoft.AspNetCore.Mvc;
using MVCassessment.Models;

namespace MVCassessment.Controllers
{
    public class VehicleController : Controller
    {
        private readonly AppDbContext _context;

        public VehicleController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Dashboard()
        {
          var vehicle =  _context.Vehicles.ToList();
            TempData["Message"] = HttpContext.Session.GetString("UserName");

            return View(vehicle);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Vehicle vehicle)
        {  _context.Vehicles.Add(vehicle);
            _context.SaveChanges();
            return RedirectToAction("Dashboard","Vehicle");
        }

        public IActionResult UserDashboard()
        {
            var vehicle = _context.Vehicles.ToList();
            TempData["Mmessage"] = HttpContext.Session.GetString("UserName");

            return View(vehicle);
        }
    }
}
