using Gabriel.Models;
using Microsoft.AspNetCore.Mvc;

namespace Gabriel.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            return View(model);
        }
    }
}
