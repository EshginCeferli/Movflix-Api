using Domain.Entities;
using Service.Services.DTOs.Movflix;

namespace Service.Services.Interfaces
{
    public interface IMovflixService
    {
        Task CreateAsync(MovflixCreateDto movflixCreateDto);
        Task<List<MovflixListDto>> GetAllAsync();
        Task DeleteAsync(int id);
        Task SoftDeleteAsync(int id);
        Task UpdateAsync(int id, MovflixUpdateDto movflixUpdateDto);
        Task<Movflix> GetByIdAsync(int id);
    }
}
