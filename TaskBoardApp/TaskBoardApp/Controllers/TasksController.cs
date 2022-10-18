using Microsoft.AspNetCore.Mvc;
using TaskBoardApp.Data;
using TaskBoardApp.Models.Task;
using TaskBoardApp.Data.Entities;
using Task = TaskBoardApp.Data.Entities.Task;
using System.Security.Claims;

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

        [HttpPost]
        public IActionResult Create(TaskFormModel taskModel)
        {
            if (!GetBoards().Any(b => b.Id == taskModel.BoardId))
            {
                this.ModelState.AddModelError(nameof(taskModel.BoardId), "Board does not exist.");
            }

            string currenrUserId = GetUserId();

            if (currenrUserId == null) throw new Exception("You don't have account");
  
            Data.Entities.Task task = new Data.Entities.Task()
            {
                Title = taskModel.Title,
                Description = taskModel.Description,
                CreatedOn = DateTime.Now,
                BoardId = taskModel.BoardId,
                OwnerId = currenrUserId

            };

            this.data.Add(task);
            this.data.SaveChanges();

            return RedirectToAction("All", "Boards");
        }

        public IActionResult Details(int id)
        {
            var task = this.data
                .Tasks
                .Where(t => t.Id == id)
                .Select(t => new TaskDetailsViewModel()
                {
                    Id = t.Id,
                    Title = t.Title,
                    Description = t.Description,
                    CreatedOn = t.CreatedOn.ToString("dd/MM/yyyy HH:mm"),
                    Board = t.Board.Name,
                    Owner = t.Owner.UserName
                })
                .FirstOrDefault();

            if (task == null)
            {
                return BadRequest();
            }

            return View(task);
        }

        private string GetUserId()
        => User.FindFirstValue(ClaimTypes.NameIdentifier);

        private IEnumerable<TaskBoardModel> GetBoards()
        => this.data
            .Boards.Select(b => new TaskBoardModel()
            {
                Id = b.Id,
                Name = b.Name
            });
    }
}
