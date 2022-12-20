using Domain.Entities;
using Service.Services.DTOs.MovieCategory;

namespace Service.Services.Interfaces
{
    public interface IMovieCategoryService
    {
        Task CreateAsync(MovieCategoryCreateDto movieCategoryCreateDto);
        Task<List<MovieCategoryListDto>> GetAllAsync();
        Task DeleteAsync(int id);
        Task SoftDeleteAsync(int id);
        Task UpdateAsync(int id, MovieCategoryUpdateDto movieCategoryUpdateDto);
        Task<MovieCategory> GetByIdAsync(int id);
    }
}
