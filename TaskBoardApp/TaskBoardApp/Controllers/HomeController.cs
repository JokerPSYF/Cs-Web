using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TaskBoardApp.Data;
using TaskBoardApp.Models;

namespace TaskBoardApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly TaskBoardAppDbContext data;

        public HomeController(TaskBoardAppDbContext context) => data = context;

        public IActionResult Index()
        {
            var taskBoards = this.data
                .Boards
                .Select(b => b.Name)
                .Distinct();

            var tasksCount = new List<HomeBoardModel>();
            foreach (var boardName in taskBoards)
            {
                var tasksBoard = this.data.Tasks.Where(t => t.Board.Name == boardName).Count();
                tasksCount.Add(new HomeBoardModel()
                {
                    BoardName = boardName,
                    TaskCount = tasksBoard
                });
            }

            var userTasksCount = -1;

            var homeModel = new HomeViewModel()
            {
                AllTasksCount = this.data.Tasks.Count(),
                BoardsWithTaskCount = tasksCount,
                UserTaskCount = userTasksCount
            };

            return View(homeModel);
        }
    }
}