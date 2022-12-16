using AutoMapper;
using Domain.Entities;
using Repository;
using Repository.Interfaces;
using Service.Services.DTOs.Movflix;
using Service.Services.DTOs.Movie;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            var movieList = (await _repo.GetAllMoviesWithCategories());
            return _mapper.Map<List<MovieListDto>>(movieList);
        }

        public async Task<Movie> GetByIdAsync(int id)
        {
            return (await _repo.GetAsync(id));
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
    }
}
