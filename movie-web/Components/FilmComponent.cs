using Microsoft.AspNetCore.Mvc;
using movie_web.Models;

namespace movie_web.Components
{
    [ViewComponent(Name = "Film")]
    public class FilmComponent:ViewComponent
    {
        public readonly DataContext _context;

        public FilmComponent(DataContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var listofFilm = (from p in _context.Films
                                  where (p.IsActive == true) && (p.Score>=8)
                                  orderby p.FilmID descending
                                  select p).ToList();
            return await Task.FromResult((IViewComponentResult)View("Default", listofFilm));
        }
    }
}
