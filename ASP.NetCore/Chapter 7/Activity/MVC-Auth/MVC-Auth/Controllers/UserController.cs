using Microsoft.AspNetCore.Mvc;
using MVC_Auth.Dto;
using MVC_Auth.Interface;

namespace MVC_Auth.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public UserController(IUserService userService, IHttpContextAccessor httpContextAccessor)
        {
            _userService = userService;
            _httpContextAccessor = httpContextAccessor;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterDto registerDto)
        {
            if (!ModelState.IsValid)
                return View(registerDto);

            var result = await _userService.RegisterUserAsync(registerDto);
            if (!result)
            {
                ModelState.AddModelError("", "Email already in use");
                return View(registerDto);
            }

            return RedirectToAction("Login");
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginDto loginDto)
        {
            if (!ModelState.IsValid)
                return View(loginDto);

            var user = await _userService.LoginAsync(loginDto);
            if (user == null)
            {
                ModelState.AddModelError("", "Invalid credentials");
                return View(loginDto);
            }

            HttpContext.Session.SetString("UserEmail", user.Email);
            return RedirectToAction("Dashboard");
        }

        public IActionResult Dashboard()
        {
            if (HttpContext.Session.GetString("UserEmail") == null)
                return RedirectToAction("Login");

            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }

}
