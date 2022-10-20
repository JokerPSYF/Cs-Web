using System.ComponentModel.DataAnnotations;
using static Watchlist.Data.Constants.DataConstants.UserConstants;
using static Watchlist.Data.Constants.DataConstants;
using Microsoft.AspNetCore.Identity;

namespace Watchlist.Data.Entitites
{
    public class User : IdentityUser
    {        
        public List<UserMovie> UserMovie { get; set; } = null!;
    }
}
