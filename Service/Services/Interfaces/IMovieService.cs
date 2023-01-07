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
        Task<MovieGetDto> GetByIdAsync(int id);
        Task<List<MovieListDto>> SearchAsync(string? searchText);
        Task<List<MovieListDto>> GetMoviesByCategoryAsync(string? category);
        Task<List<MovieListDto>> GetMoviesDesOrderAsync();
        Task<List<MovieListDto>> GetMoviesRateOrderAsync();
        Task RateAsync(int id, float rate);
    }
}
