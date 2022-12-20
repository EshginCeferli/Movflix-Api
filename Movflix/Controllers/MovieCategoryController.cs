using Microsoft.AspNetCore.Mvc;
using Service.Services.DTOs.Movie;
using Service.Services.DTOs.MovieCategory;
using Service.Services.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Movflix.Controllers
{
    public class MovieCategoryController : AppController
    {
        private readonly IMovieCategoryService _categoryService;

        public MovieCategoryController(IMovieCategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] MovieCategoryCreateDto movieCategoryCreateDto)
        {
            await _categoryService.CreateAsync(movieCategoryCreateDto);

            return Ok();
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Update([FromRoute][Required] int id, MovieCategoryUpdateDto movieCategoryUpdateDto)
        {
            try
            {
                await _categoryService.UpdateAsync(id, movieCategoryUpdateDto);

                return Ok(movieCategoryUpdateDto);
            }
            catch (NullReferenceException)
            {
                return NotFound();
            }
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([Required] int id)
        {
            try
            {
                await _categoryService.DeleteAsync(id);
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
                await _categoryService.SoftDeleteAsync(id);
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
            var result = await _categoryService.GetAllAsync();
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> Get([Required] int id)
        {
            try
            {
                return Ok(await _categoryService.GetByIdAsync(id));
            }
            catch (NullReferenceException)
            {
                return NotFound();
            }
        }

    }
}
