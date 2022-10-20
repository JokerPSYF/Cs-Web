using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Watchlist.Data.Entitites;
using static Watchlist.Data.Constants.DataConstants.MovieConstants;
using static Watchlist.Data.Constants.DataConstants;

namespace Watchlist.Models.Movies
{
    public class MovieViewModel
    {
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
        public string Genre { get; set; }
    }
}
