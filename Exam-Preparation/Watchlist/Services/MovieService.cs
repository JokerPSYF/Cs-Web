using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Watchlist.Data;
using Watchlist.Data.Entitites;
using Watchlist.Intefaces;
using Watchlist.Models.Movies;

namespace Watchlist.Services
{
    public class MovieService : IMovieService
    {
        private readonly WatchlistDbContext data;

        public MovieService(WatchlistDbContext context)
        {
            this.data = context;
        }

        public async Task<IEnumerable<MovieViewModel>> GetAllAsync()
        {
            var entities = await this.data.Movies
                .Include(x => x.Genre )
                .ToListAsync();

            return entities
                 .Select(m => new MovieViewModel()
                 {
                     Id = m.Id,
                     Title = m.Title,
                     Director = m.Director,
                     Rating = m.Rating,
                     Genre = m.Genre.Name,
                     ImageUrl = m.ImageUrl
                 });
        }

        public async Task<IEnumerable<Genre>> GetGenresAsync()
        {
            return await this.data.Genres.ToListAsync();
        }

        public async Task AddMovieAsync(AddMovieViewModel model)
        {
            var movie = new Movie()
            {
                Title = model.Title,
                Director = model.Director,
                ImageUrl = model.ImageUrl,
                Rating = model.Rating,
                GenreId = model.GenreId

            };

            await this.data.AddAsync(movie);
            await this.data.SaveChangesAsync();
        }

        public async Task AddMovieToCollectionAsync(int movieId, string userId)
        {
            var user = await this.data.Users
                .Where(u => u.Id == userId)
                .Include(u => u.UserMovie)
                .FirstOrDefaultAsync();

            if (user == null)
            {
                throw new ArgumentException("Invalid user ID");
            }

            var movie = await this.data.Movies.FirstOrDefaultAsync(m => m.Id == movieId);

            if (movie == null)
            {
                throw new ArgumentException("Invalid movie ID");
            }

            if (!user.UserMovie.Any(m => m.MovieId == movieId))
            {
                user.UserMovie.Add(new UserMovie
                {
                    MovieId = movieId,
                    UserId = userId,
                    Movie = movie,
                    User = user
                });

                await this.data.SaveChangesAsync();
            }
        }

        public async Task RemoveMovieFromCollectionAsync(int movieId, string userId)
        {
            var user = await this.data.Users
                .Where(u => u.Id == userId)
                .Include(u => u.UserMovie)
                .FirstOrDefaultAsync();

            if (user == null)
            {
                throw new ArgumentException("Invalid user ID");
            }

            var movie = user.UserMovie.FirstOrDefault(m => m.MovieId == movieId);

            if (movie != null)
            {
                 user.UserMovie.Remove(movie);

                await this.data.SaveChangesAsync();
            }
        }
    }
}
