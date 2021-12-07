using Microsoft.AspNetCore.Mvc;



namespace Gabriel.Controllers
{
    public class MusicController : Controller
    {
        public IActionResult Compositions()
        {
            return View();
        }
    }
}
