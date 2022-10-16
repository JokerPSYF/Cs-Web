using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static TaskBoardApp.Data.Constants.DataConstants.User;

namespace TaskBoardApp.Data.Entities
{
    public class User : IdentityUser
    {
        //[Key]
        //[Comment("The Unique Key of the user")]
        //[UIHint("hidden")]
        //public int Id { get; init; }

        [Required]
        [Comment("The first name of the user")]
        [MaxLength(FNameMax, ErrorMessage = FNameErrorMessage)]
        public string FirstName { get; init; } = null!;

        [Required]
        [Comment("The last name of the user")]
        [MaxLength(LNameMax, ErrorMessage = LNameErrorMessage)]
        public string LastName { get; init; } = null!;
    }
}
