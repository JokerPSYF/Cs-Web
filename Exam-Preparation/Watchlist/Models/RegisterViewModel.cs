using System.ComponentModel.DataAnnotations;
using static Watchlist.Data.Constants.DataConstants.UserConstants;
using static Watchlist.Data.Constants.DataConstants;

namespace Watchlist.Models
{
    public class RegisterViewModel
    {
        [Required]
        [StringLength(MaxName, MinimumLength = MinName, ErrorMessage = ErrorMessage)]
        public string UserName { get; set; } = null!;

        [Required]
        [StringLength(MaxEmail, MinimumLength = MinEmail, ErrorMessage = ErrorMessage)]
        public string Email { get; set; } = null!;

        [Required]
        [StringLength(MaxPassword, MinimumLength = MinPassword, ErrorMessage = ErrorMessage)]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;
        
        [Required]
        [StringLength(MaxPassword, MinimumLength = MinPassword, ErrorMessage = ErrorMessage)]
        [DataType(DataType.Password)]
        [Compare("Passord", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; } = null!;
    }
}
