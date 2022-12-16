using AutoMapper;
using Domain.Entities;
using Repository.Interfaces;
using Service.Services.DTOs.Movie;
using Service.Services.DTOs.MovieCategory;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class MovieCategoryService : IMovieCategoryService
    {
        private readonly IMovieCategoryRepository _repo;
        private readonly IMapper _mapper;

        public MovieCategoryService(IMovieCategoryRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task CreateAsync(MovieCategoryCreateDto movieCategoryCreateDto)
        {
            var mappedData = _mapper.Map<MovieCategory>(movieCategoryCreateDto);
            await _repo.CreateAsync(mappedData);
        }

        public async Task DeleteAsync(int id)
        {
            var movieCategory = await _repo.GetAsync(id);

            await _repo.DeleteAsync(movieCategory);
        }

        public async Task<List<MovieCategoryListDto>> GetAllAsync()
        {
            return _mapper.Map<List<MovieCategoryListDto>>(await _repo.GetAllAsync());
        }

        public async Task<MovieCategory> GetByIdAsync(int id)
        {
            return (await _repo.GetAsync(id));
        }

        public async Task SoftDeleteAsync(int id)
        {
            var movieCategory = await _repo.GetAsync(id);

            await _repo.SoftDeleteAsync(movieCategory);


        }

        public async Task UpdateAsync(int id, MovieCategoryUpdateDto movieCategoryUpdateDto)
        {
            var dbMovieCategory = await _repo.GetAsync(id);

            _mapper.Map(movieCategoryUpdateDto, dbMovieCategory);

            await _repo.UpdateAsync(dbMovieCategory);
        }
    }
}
