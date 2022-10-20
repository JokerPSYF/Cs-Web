using Watchlist.Data.Entitites;
using Watchlist.Models.Movies;

namespace Watchlist.Intefaces
{
    public interface IMovieService
    {
        Task<IEnumerable<MovieViewModel>> GetAllAsync();

        Task<IEnumerable<Genre>> GetGenresAsync();

        Task AddMovieAsync(AddMovieViewModel model);

        Task AddMovieToCollectionAsync(int movieId, string userId);

        Task RemoveMovieFromCollectionAsync(int movieId, string userId);
    }
}
