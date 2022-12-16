using Domain.Entities;
using Service.Services.DTOs.Movflix;
using Service.Services.DTOs.Movie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Interfaces
{
    public interface IMovieService
    {
        Task CreateAsync(MovieCreateDto movieCreateDto);
        Task<List<MovieListDto>> GetAllAsync();
        Task DeleteAsync(int id);
        Task SoftDeleteAsync(int id);
        Task UpdateAsync(int id, MovieUpdateDto movieUpdateDto);
        Task<Movie> GetByIdAsync(int id);
    }
}
