using Domain.Entities;

namespace Repository.Interfaces
{
    public interface IMovieRepository : IRepository<Movie>
    {
        Task<List<Movie>> GetAllMoviesWithCategories();
        Task<Movie> GetMovieById(int? id);
        Task<List<Movie>> GetMoviesBySearch(string? searchText);

        public Task RateMovie(int id, float rate);
    }
}
