using Microsoft.AspNetCore.Mvc;

namespace Watchlist.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
