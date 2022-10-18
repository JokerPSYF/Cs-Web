using Microsoft.AspNetCore.Mvc;
using TaskBoardApp.Data;
using TaskBoardApp.Models.Task;

namespace TaskBoardApp.Controllers
{
    public class TasksController : Controller
    {
        private readonly TaskBoardAppDbContext data;

        public TasksController(TaskBoardAppDbContext context) => data = context;

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            TaskFormModel taskModel = new TaskFormModel()
            {
                Boards = GetBoards()
            };

            return View(taskModel);
        }

        //  TODO: POST CREATE(), implement GetBoard

        private IEnumerable<TaskBoardModel> GetBoards()
        {
            throw new NotImplementedException();
        }
    }
}
