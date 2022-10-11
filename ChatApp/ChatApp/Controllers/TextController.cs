using ChatApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace ChatApp.Controllers
{
    public class TextController : Controller
    {
        public IActionResult Index(TextViewModel model) => View(model);

        [HttpPost]
        public IActionResult Split(TextViewModel model)
        {
            var splitTextArray = model.Text
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            model.SplitText = String.Join(Environment.NewLine, splitTextArray);

            return RedirectToAction("Index", model);
        }
    }
}
