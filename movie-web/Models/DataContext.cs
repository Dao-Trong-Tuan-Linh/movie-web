using Microsoft.EntityFrameworkCore;
using movie_web.Areas.Admin.Models;

namespace movie_web.Models
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {
        }

        public DbSet<Menu> Menus { get; set; }  
        public DbSet<Category> Categories { get; set; }
        public DbSet<Film> Films { get; set; }

        public DbSet<Film> NewFilms { get; set; }

        public DbSet<TvShow> TvShows { get; set; }
       public DbSet<AdminMenu> AdminMenus { get; set; }

    }
}
