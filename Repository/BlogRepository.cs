using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Repository.Data;
using Repository.Interfaces;

namespace Repository
{
    public class BlogRepository : Repository<Blog>, IBlogRepository
    {
        private readonly AppDbContext _context;
        private readonly DbSet<Blog> _entities;


        public BlogRepository(AppDbContext context) : base(context)
        {
            _context = context;
            _entities = _context.Set<Blog>();
        }

        public async Task<Blog> GetBlogById(int id)
        {
            var blog = await _entities
                .Include(m => m.BlogImages)
                .Include(m => m.Comments)
                 .FirstOrDefaultAsync(m => m.Id == id);

            if (blog == null) throw new NullReferenceException();
            return blog;
        }

        public async Task<List<Blog>> GetBlogWithImages()
        {
            var blogs = await _entities.
                 Include(x => x.BlogImages)                 
                 .ToListAsync();

            return blogs;
        }

        public async Task<List<Blog>> GetRecentBlogs()
        {
           var blogs = await _entities
                .OrderByDescending(x => x.Id)
               
                .Take(3)
                .ToListAsync();

            return blogs;
        }
    }
}
