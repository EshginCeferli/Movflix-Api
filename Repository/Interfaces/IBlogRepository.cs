using Domain.Entities;

namespace Repository.Interfaces
{
    public interface IBlogRepository : IRepository<Blog>
    {
        Task<List<Blog>> GetBlogWithImages();
        Task<Blog> GetBlogById(int id);
        Task<List<Blog>>GetRecentBlogs();
    }
}
