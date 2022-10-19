using System.ComponentModel.DataAnnotations;
using static Watchlist.Data.Constants.DataConstants.MovieConstants;
using static Watchlist.Data.Constants.DataConstants;
using System.ComponentModel.DataAnnotations.Schema;

namespace Watchlist.Data.Entitites
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(MaxTitle, MinimumLength = MinTitle, ErrorMessage = ErrorMessage)]
        public string Title { get; set; } = null!;


        [Required]
        [StringLength(MaxDirector, MinimumLength = MinDirector, ErrorMessage = ErrorMessage)]
        public string Director { get; set; } = null!;


        [Required]
        public string ImageUrl { get; set; } = null!;


        [Required]
        [Range((double)MinRate, (double)MaxRate)]
        public decimal Rating { get; set; }


        [Required]
        [ForeignKey(nameof(Genre))]
        public int GenreId{ get; set; }

        [Required]
        public Genre Genre { get; set; }

        public List<UserMovie> UserMovies { get; set; } = new List<UserMovie>();
    }
}
