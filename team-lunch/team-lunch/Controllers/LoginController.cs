using Microsoft.AspNetCore.Mvc;

namespace team_lunch.Controllers
{
    public class LoginController : Controller
    {
        // GET: /HelloWorld/
        public ViewResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 
        public string Welcome(string name)
        {

            return "This is the Welcome action method..." + name;
        }
    }
}