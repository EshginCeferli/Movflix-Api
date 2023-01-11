using AutoMapper;
using Domain.Entities;
using Repository.Interfaces;
using Service.Services.DTOs.Movie;
using Service.Services.Interfaces;
using System.Runtime.InteropServices;

namespace Service.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _repo;
        private readonly IMapper _mapper;

        public MovieService(IMovieRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task CreateAsync(MovieCreateDto movieCreateDto)
        {
            var mappedData = _mapper.Map<Movie>(movieCreateDto);
            await _repo.CreateAsync(mappedData);
        }

        public async Task DeleteAsync(int id)
        {
            var movie = await _repo.GetAsync(id);

            await _repo.DeleteAsync(movie);
        }

        public async Task<List<MovieListDto>> GetAllAsync()
        {
            var movieList = await _repo.GetAllMoviesWithCategories();
            return _mapper.Map<List<MovieListDto>>(movieList);
        }

        public async Task<MovieGetDto> GetByIdAsync(int id)
        {
            var mappedMovie = _mapper.Map<MovieGetDto>(await _repo.GetMovieById(id));
            
           
            return mappedMovie;
        }

        public async Task<List<MovieListDto>> SearchAsync(string? searchText)
        {
            List<Movie> searchDatas = new();

            if (searchText != null)
            {
                searchDatas = await _repo.GetMoviesBySearch(searchText);
            }
            else
            {
                searchDatas = await _repo.GetAllMoviesWithCategories();
            }

            return _mapper.Map<List<MovieListDto>>(searchDatas);
        }

        public async Task SoftDeleteAsync(int id)
        {
            var movie = await _repo.GetAsync(id);

            await _repo.SoftDeleteAsync(movie);
        }

        public async Task UpdateAsync(int id, MovieUpdateDto movieUpdateDto)
        {
            var dbMovie = await _repo.GetAsync(id);

            _mapper.Map(movieUpdateDto, dbMovie);

            await _repo.UpdateAsync(dbMovie);
        }

    

        public async Task RateAsync(int id, float rate)
        {
            await _repo.RateMovie(id, rate);  
            
        }

        public async Task<List<MovieListDto>> GetMoviesByCategoryAsync(string? category)
        {
            var dbMovies = await _repo.GetMoviesByCategory(category);

            var mappedMovies = _mapper.Map<List<MovieListDto>>(dbMovies);

            return mappedMovies;
        }

        public async Task<List<MovieListDto>> GetMoviesDesOrderAsync()
        {
            var dbMovies = await _repo.GetMoviesDescOrder();

            var mappedMovies = _mapper.Map<List<MovieListDto>>(dbMovies);

            return mappedMovies;
        }

        public async Task<List<MovieListDto>> GetMoviesRateOrderAsync()
        {
            var dbMovies = await _repo.GetMoviesRateDesc();

            var mappedMovies = _mapper.Map<List<MovieListDto>>(dbMovies);

            return mappedMovies;
        }

        public async Task<List<MovieListDto>> RelatedMoviesAsync(int id)
        {
            var dbMovies = await _repo.RelatedMovies(id);

            var mappedMovies = _mapper.Map<List<MovieListDto>>(dbMovies);

            return mappedMovies;
        }
    }
}
