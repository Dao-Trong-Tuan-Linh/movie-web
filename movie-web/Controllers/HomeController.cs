using Microsoft.AspNetCore.Mvc;
using movie_web.Models;
using System.Diagnostics;

namespace movie_web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DataContext _context;

        public HomeController(ILogger<HomeController> logger,DataContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Route("/list-{slug}-{id:int}.html",Name ="List")]
        public IActionResult List(int? id)
        {
            if(id==null)
            {
                return NotFound();

            }
            var list = _context.Films.Where(m => (m.CategoryID == id) && (m.IsActive == true))
                .ToList();
            if(list==null)
            {
                return NotFound();
            }
            return View(list);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}