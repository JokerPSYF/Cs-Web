using System.ComponentModel.DataAnnotations;
using Watchlist.Data.Entitites;
using static Watchlist.Data.Constants.DataConstants.MovieConstants;
using static Watchlist.Data.Constants.DataConstants;

namespace Watchlist.Models.Movies
{
    public class AddMovieViewModel
    {
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

        public int GenreId { get; set; }

        public IEnumerable<Genre> Genres { get; set; } = new List<Genre>();
    }
}
