using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace movie_web.Models
{
    [Table("View_Film_Category")]
    public class Film
    {
        [Key]
        public int FilmID { get; set; }
        public string? FilmName { get; set; }
        public bool? IsActive { get; set; }
        public double? Score { get; set; }
        public string? Image { get; set; }
        public int? CategoryID { get; set; }
        public string? CategoryName { get; set; }
        public DateTime? Date { get; set; }
        public int GenreID { get; set; }
        public string? Details { get; set; }

    }
}
