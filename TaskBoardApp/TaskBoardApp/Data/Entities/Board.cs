using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static TaskBoardApp.Data.Constants.DataConstants.Board;

namespace TaskBoardApp.Data.Entities
{
    public class Board
    {
        [Key]
        [Comment("Unique identifier of the board")]
        public int Id { get; init; }

        [Required]
        [StringLength(MaxBoardName, MinimumLength = MinBoardName, ErrorMessage = ErrorMessageBoardName)]
        [Comment("Name of the board")]
        public string Name { get; init; } = null!;

        [Comment("List with tasks of the board")]
        public IEnumerable<Task> Tasks { get; set; } = new List<Task>();
    }
}
