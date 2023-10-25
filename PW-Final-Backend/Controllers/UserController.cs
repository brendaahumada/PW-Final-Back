using Microsoft.AspNetCore.Mvc;

namespace PW_Final_Backend.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
