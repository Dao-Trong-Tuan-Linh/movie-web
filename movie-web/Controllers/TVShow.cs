using Microsoft.AspNetCore.Mvc;

namespace movie_web.Controllers
{
    public class TVShow : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
