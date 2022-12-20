using Domain.Entities;

namespace Repository.Interfaces
{
    public interface IMovieRepository : IRepository<Movie>
    {
        Task<List<Movie>> GetAllMoviesWithCategories();
        Task<List<Movie>> GetMoviesBySearch(string? searchText);
    }
}
