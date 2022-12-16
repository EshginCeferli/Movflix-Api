using Domain.Entities;
using Repository.Data;
using Repository.Interfaces;

namespace Repository
{
    public class BlogRepository : Repository<Blog>, IBlogRepository
    {
        public BlogRepository(AppDbContext context) : base(context) { }

    }
}
