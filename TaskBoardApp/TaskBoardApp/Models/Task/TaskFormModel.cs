using System.ComponentModel.DataAnnotations;
using static TaskBoardApp.Data.Constants.DataConstants.Task;

namespace TaskBoardApp.Models.Task
{
    public class TaskFormModel
    {
        [Required]
        [StringLength(MaxTaskTitle, MinimumLength = MinTaskTitle, ErrorMessage = ErrorMessageTaskTitle)]
        public string Title { get; set; }

        [Required]
        [StringLength(MaxTaskDescription, MinimumLength = MinTaskDescription, ErrorMessage = ErrorMessageTaskDescription)]
        public string Description { get; set; }

        [Display(Name= "Board")]
        public int BoardId { get; set; }

        public IEnumerable<TaskBoardModel> Boards { get; set; }
    }
}
