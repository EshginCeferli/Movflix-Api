using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Repository.Data;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class MovieRepository : Repository<Movie>, IMovieRepository
    {
        private readonly AppDbContext _context;
        private readonly DbSet<Movie> _entities;
        public MovieRepository(AppDbContext context) : base(context) 
        {
            _context= context;
            _entities = _context.Set<Movie>();
        }

        public async Task<List<Movie>> GetAllMoviesWithCategories()
        {
            return await _entities
                .Where(m=>m.SoftDeleted==false)
                .Include(m => m.MovieCategory)
                .ToListAsync();
        }
    }
}
