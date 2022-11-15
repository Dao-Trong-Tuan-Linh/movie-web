using Microsoft.AspNetCore.Mvc;
using movie_web.Models;
namespace movie_web.Components
{
    [ViewComponent(Name ="TvShow")]
    public class TvShowComponent:ViewComponent
    {
        private readonly DataContext _context;
        public TvShowComponent(DataContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var listofTvShow = (from p in _context.TvShows
                                  where (p.IsActive == true)
                                  orderby p.TvShowID descending
                                  select p).ToList();
            return await Task.FromResult((IViewComponentResult)View("Default", listofTvShow));
        }
    }
}
