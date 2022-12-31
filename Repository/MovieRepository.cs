using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Repository.Data;
using Repository.Interfaces;

namespace Repository
{
    public class MovieRepository : Repository<Movie>, IMovieRepository
    {
        private readonly AppDbContext _context;
        private readonly DbSet<Movie> _entities;
        public MovieRepository(AppDbContext context) : base(context)
        {
            _context = context;
            _entities = _context.Set<Movie>();
        }

        public async Task<List<Movie>> GetAllMoviesWithCategories()
        {
            var movies = await _entities
                .Where(m => m.SoftDeleted == false)
                .Include(m => m.MovieCategory)
                .ToListAsync();
            return movies;
        }


        public async Task<Movie> GetMovieById(int? id)
        {
            if (id == null) throw new ArgumentNullException();

            var movie = await _entities
                .Include(m => m.MovieCategory)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (movie == null) throw new NullReferenceException();

            return movie;
        }

        public async Task<List<Movie>> GetMoviesBySearch(string? searchText)
        {
            var searchMovie = await
                 _entities
                 .Where(m => m.Name.Contains(searchText))
                 .Include(m => m.MovieCategory)
                 .ToListAsync();

            if (searchMovie is null) throw new NullReferenceException();

            return searchMovie;
        }
    }
}
