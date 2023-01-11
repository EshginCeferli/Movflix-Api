using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.Services.DTOs.Blog;
using Service.Services.DTOs.Movie;
using Service.Services.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace Movflix.Controllers
{
    public class MovieController : AppController
    {
        private readonly IMovieService _movieService;

        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]

        public async Task<IActionResult> Create([FromBody] MovieCreateDto movieCreateDto)
        {
            await _movieService.CreateAsync(movieCreateDto);

            return Ok();
        }

        [HttpPut]
        [Route("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Update([FromRoute][Required] int id, MovieUpdateDto movieUpdateDto)
        {
            try
            {
                await _movieService.UpdateAsync(id, movieUpdateDto);

                return Ok(movieUpdateDto);
            }
            catch (NullReferenceException)
            {
                return NotFound();
            }
        }



        [HttpDelete]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete([Required] int id)
        {
            try
            {
                await _movieService.DeleteAsync(id);
                return Ok();
            }
            catch (NullReferenceException)
            {

                return NotFound();
            }
        }

        [HttpPost]
        public async Task<IActionResult> SoftDelete([Required] int id)
        {
            try
            {
                await _movieService.SoftDeleteAsync(id);
                return Ok();
            }
            catch (NullReferenceException)
            {

                return NotFound();
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _movieService.GetAllAsync());
        }

        [HttpGet]
        public async Task<IActionResult> Get([Required] int id)
        {
            try
            {
                return Ok(await _movieService.GetByIdAsync(id));
            }
            catch (NullReferenceException)
            {
                return NotFound();
            }
        }

        [HttpGet]
        public async Task<IActionResult> Search(string? search)
        {
            return Ok(await _movieService.SearchAsync(search));
        }

        [HttpPost]        
        public async Task<IActionResult> Rate([Required] int id, [FromQuery]float rate)
        {
           await _movieService.RateAsync(id, rate);         

            return Ok();
        }

        [HttpGet]
   
        public async Task<IActionResult> GetMoviesByCategory([FromQuery] string category)
        {       
            return Ok(await _movieService.GetMoviesByCategoryAsync(category));
        }

        [HttpGet]
        public async Task<IActionResult> GetMoviesDescOrder()
        {
            return Ok(await _movieService.GetMoviesDesOrderAsync());
        }

        [HttpGet]
        public async Task<IActionResult> GetMoviesRateOrder()
        {
            return Ok(await _movieService.GetMoviesRateOrderAsync());
        }
    }
}
