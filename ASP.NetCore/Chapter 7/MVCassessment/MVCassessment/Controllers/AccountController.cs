using Microsoft.AspNetCore.Mvc;
using MVCassessment.Models;

namespace MVCassessment.Controllers
{
    public class AccountController : Controller
    {
        private readonly AppDbContext _context;

        public AccountController(AppDbContext context)
        {
            _context = context;

        }

        
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(User user)
        {   
            if(!ModelState.IsValid)
            {
                return View();
            }

            var existingUser = _context.Users.Any(u=>u.Username==user.Username);
            if(existingUser)
            {
                ModelState.AddModelError("","User already Exist");
                return View(user);
            }
            _context.Users.Add(user);
            _context.SaveChanges();
            return RedirectToAction("Login","Account");


        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(User user)
        {
            var loggedUser = _context.Users.FirstOrDefault(u=>u.Username==user.Username && u.Password==user.Password);
            if(loggedUser==null)
            {
                return NotFound();
            }

            HttpContext.Session.SetInt32("UserId",loggedUser.UserId);
            HttpContext.Session.SetString("UserName",loggedUser.Username);

            if(loggedUser.Role==Enums.UserRole.Admin)
            {
                return RedirectToAction("Dashboard","Vehicle");
            }
            return RedirectToAction("UserDashboard", "Vehicle");

        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login", "Account");

        }
    }
}
