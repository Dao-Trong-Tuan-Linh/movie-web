using Microsoft.AspNetCore.Mvc;
using movie_web.Models;

namespace movie_web.Components
{
    [ViewComponent(Name ="Category")]
    public class CategoryComponent:ViewComponent
    {
        public readonly DataContext _context;

        public CategoryComponent(DataContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var listofCategory = (from p in _context.Categories
                                  where (p.IsActive == true)
                                  orderby p.CategoryID descending
                                  select p).Take(6).ToList();
            return await Task.FromResult((IViewComponentResult)View("Default",listofCategory));
        }
    }
}
