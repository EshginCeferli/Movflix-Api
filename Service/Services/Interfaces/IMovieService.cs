using Domain.Entities;
using Service.Services.DTOs.Movie;

namespace Service.Services.Interfaces
{
    public interface IMovieService
    {
        Task CreateAsync(MovieCreateDto movieCreateDto);
        Task<List<MovieListDto>> GetAllAsync();
        Task DeleteAsync(int id);
        Task SoftDeleteAsync(int id);
        Task UpdateAsync(int id, MovieUpdateDto movieUpdateDto);
        Task<Movie> GetByIdAsync(int id);
        Task<List<MovieListDto>> SearchAsync(string? searchText);
    }
}
