using System.ComponentModel.DataAnnotations;
using static Watchlist.Data.Constants.DataConstants.UserConstants;
using static Watchlist.Data.Constants.DataConstants;
using Microsoft.AspNetCore.Identity;

namespace Watchlist.Data.Entitites
{
    public class User : IdentityUser
    {
        //[Key]
        //public string Id { get; set; }

        //[Required]
        //[StringLength(MaxName, MinimumLength = MinName, ErrorMessage = ErrorMessage)]
        //public string UserName { get; set; } = null!;

        //[Required]
        //[StringLength(MaxEmail, MinimumLength = MinEmail, ErrorMessage = ErrorMessage)]
        //public string Email { get; set; } = null!;

        //[Required]
        //[StringLength(MaxPassword, MinimumLength = MinPassword, ErrorMessage = ErrorMessage)]
        //[DataType(Password)]
        //public string Password { get; set; } = null!;
        
        public List<UserMovie> UserMovie { get; set; } = null!;
    }
}
