using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static TaskBoard.Infrastructure.Constants.DataConstants.User;

namespace TaskBoard.Infrastructure.Entities
{
    public class User : IdentityUser
    {
        [Key]
        [Comment("The Unique Key of the user")]
        public int Id { get; init; }

        [Required]
        [Comment("The first name of the user")]
        [MaxLength(FNameMax, ErrorMessage = FNameErrorMessage )]
        public string FirstName { get; init; }

        [Required]
        [Comment("The last name of the user")]
        [MaxLength(LNameMax, ErrorMessage = LNameErrorMessage)]
        public string LastName { get; init; }
    }
}
