using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static TaskBoardApp.Data.Constants.DataConstants.Task;

namespace TaskBoardApp.Data.Entities
{
    public class Task
    {
        [Key]
        [Comment("Unique identifier of the task")]
        public int Id { get; set; }

        [Required]
        [StringLength(MaxTaskTitle, MinimumLength = MinTaskTitle, ErrorMessage = ErrorMessageTaskTitle)]
        [Comment("Title of the Task")]
        public string Title { get; set; } = null!;

        [Required]
        [StringLength(MaxTaskDescription, MinimumLength = MinTaskDescription, ErrorMessage = ErrorMessageTaskDescription)]
        [Comment("Description of the Task")]
        public string Description { get; set; } = null!;

        [Comment("Date where the task was created")]
        public DateTime CreatedOn { get; set; }

        [Comment("Board unique identifier")]
        public int BoardId { get; set; }

        [Comment("Board of the task")]
        public Board Board { get; init; }

        [Required]
        [Comment("Owner's unique identifier")]
        public string OwnerId { get; set; } = null!;

        [Comment("Owner of the task")]
        public User Owner { get; init; } = null!;
    }
}
