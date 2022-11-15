using Microsoft.AspNetCore.Mvc;
using movie_web.Models;

namespace movie_web.Components
{
    [ViewComponent(Name = "NewFilms")]

    public class NewFilmComponent : ViewComponent
    {
        private DataContext _context;
        public NewFilmComponent(DataContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var listofNewFilms = (from m in _context.NewFilms
                                  orderby m.Date descending
                                  select m).ToList();
            return await Task.FromResult((IViewComponentResult)View("Default", listofNewFilms));
        }
    }
}
