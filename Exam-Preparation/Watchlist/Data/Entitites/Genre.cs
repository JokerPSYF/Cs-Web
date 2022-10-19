using System.ComponentModel.DataAnnotations;
using static Watchlist.Data.Constants.DataConstants.GenreConstants;
using static Watchlist.Data.Constants.DataConstants;

namespace Watchlist.Data.Entitites
{
    public class Genre
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(MaxName, MinimumLength = MinName, ErrorMessage = ErrorMessage)]
        public string Name { get; set; } = null!;

        public List<Movie> Movies { get; set; } = new List<Movie>();
    }
}
