using Domain.Entities;
using Service.Services.DTOs.Blog;

namespace Service.Services.Interfaces
{
    public interface IBlogService
    {
        Task CreateAsync(BlogCreateDto blogCreateDto);
        Task<List<BlogListDto>> GetAllAsync();
        Task DeleteAsync(int id);
        Task SoftDeleteAsync(int id);
        Task UpdateAsync(int id, BlogUpdateDto blogUpdateDto);
        Task<BlogGetDto> GetByIdAsync(int id);
        Task<List<BlogListDto>>GetRecentBlogsAsync();
    }
}
