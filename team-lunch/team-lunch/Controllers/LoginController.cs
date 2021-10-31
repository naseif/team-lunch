using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using team_lunch.Models;

namespace team_lunch.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILogger<LoginController> _logger;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ISession _session;

        public LoginController(IHttpContextAccessor httpContextAccessor, ILogger<LoginController> logger)
        {
            _logger = logger;
            _httpContextAccessor = httpContextAccessor;
            _session = _httpContextAccessor.HttpContext.Session;
        }

        public ViewResult Index()
        {
            return View(new LoginViewModel(""));
        }

        public IActionResult Login(string email, string password)
        {
            if (email == "coder@coder.com")
            {
                if (password == "1234")
                {
                    _session.SetString("username", email);
                    return RedirectToAction("welcome");
                }
            }
            return View("index", new LoginViewModel("Your Login Failed, Please check your password!"));
        }

        public IActionResult Welcome()
        {
            return View();
        }
    }
}