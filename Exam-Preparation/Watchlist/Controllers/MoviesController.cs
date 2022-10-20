using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Watchlist.Data;
using Watchlist.Intefaces;
using Watchlist.Models.Movies;

namespace Watchlist.Controllers
{
    [Authorize]
    public class MoviesController : Controller
    {
        private readonly WatchlistDbContext data;
        private readonly IMovieService service;

        public MoviesController(
            WatchlistDbContext context,
            IMovieService service
            )
        {
            data = context;
            this.service = service;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var model = await this.service.GetAllAsync();

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var model = new AddMovieViewModel()
            {
                Genres = await service.GetGenresAsync()
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddMovieViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await service.AddMovieAsync(model);
                return RedirectToAction(nameof(All));
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Something went wrong");

                return View(model);
            }
        }

        public async Task<IActionResult> AddToCollection(int movieId)
        {
            try
            {
                var userId = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
                await this.service.AddMovieToCollectionAsync(movieId, userId);
            }
            catch (Exception)
            {
                BadRequest();
            }
            return RedirectToAction(nameof(All));
        }
    }
}
