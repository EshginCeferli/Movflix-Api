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
                .Include(m => m.Comments)
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

        public async Task RateMovie(int id, float rate)
        {
            var movie = await _entities.FirstOrDefaultAsync(m => m.Id == id);

            movie.Rating += rate;

            await _context.SaveChangesAsync();
           
        }

        public async Task<List<Movie>> GetMoviesByCategory(string category)
        {
            if (category is null) throw new NullReferenceException();

            var result = await _entities
                .Include(m => m.MovieCategory)
                .Where(m => m.MovieCategory.Name == category)
                .Take(10)
                .ToListAsync();

            if (result is null) throw new DllNotFoundException();
            
            return result;                
        }

        public async Task<List<Movie>> RelatedMovies(int id)
        {
            var movie = await _entities.Include(m => m.MovieCategory)
                .Where(m => m.Id == id).FirstOrDefaultAsync();

            var movies = await _entities.Include(m => m.MovieCategory)
                .Where(m => m.MovieCategoryId == movie.MovieCategoryId)
                .ToListAsync();

            return movies;              


        }

        public async Task<List<Movie>> GetMoviesDescOrder()
        {
            var result = await _entities
                .Include(m => m.MovieCategory)
                .OrderByDescending(m => m.Id)
                .Take(8)
                .ToListAsync();

            if (result is null) throw new NullReferenceException();

            return result;
        }

        public async Task<List<Movie>> GetMoviesRateDesc()
        {
            var result = await _entities
                .Include(m => m.MovieCategory)
                .OrderByDescending(m => m.Rating)
                .Take(8)
                .ToListAsync();

            return result;
        }
    }
}
