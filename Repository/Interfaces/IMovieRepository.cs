using Domain.Entities;

namespace Repository.Interfaces
{
    public interface IMovieRepository : IRepository<Movie>
    {
        Task<List<Movie>> GetAllMoviesWithCategories();
        Task<Movie> GetMovieById(int? id);
        Task<List<Movie>> GetMoviesBySearch(string? searchText);
        Task<List<Movie>> GetMoviesByCategory(string? category);
        Task<List<Movie>> RelatedMovies(int id);
        Task<List<Movie>> GetMoviesDescOrder();
        Task<List<Movie>> GetMoviesRateDesc();
        Task RateMovie(int id, float rate);
    }
}
