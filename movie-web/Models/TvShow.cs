using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace movie_web.Models
{
    [Table("TvShow")]
    public class TvShow
    {
        [Key]
        public int TvShowID { get; set; }
        public string? Name { get; set; }
        public int? Ep { get; set; }
        public double? Score { get; set; }
        public DateTime Time { get; set; }

        public string? Image { get; set; } 
        public bool? IsActive { get; set; }

    }
}
