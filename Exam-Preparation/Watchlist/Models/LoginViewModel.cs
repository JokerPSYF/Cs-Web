using System.ComponentModel.DataAnnotations;
using static Watchlist.Data.Constants.DataConstants.UserConstants;
using static Watchlist.Data.Constants.DataConstants;

namespace Watchlist.Models
{
    public class LoginViewModel
    {
        [Required]
        public string UserName { get; set; } = null!;


        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;
    }
}
