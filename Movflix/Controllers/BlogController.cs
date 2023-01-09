using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.Services.DTOs.Blog;
using Service.Services.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace Movflix.Controllers
{
    public class BlogController : AppController
    {
        private readonly IBlogService _blogService;

        public BlogController(IBlogService blogService)
        {
            _blogService = blogService;
        }

        [HttpPost]
        //[Authorize(Roles = "Admin")]

        public async Task<IActionResult> Create([FromBody] BlogCreateDto blogCreateDto)
        {
            await _blogService.CreateAsync(blogCreateDto);

            return Ok();
        }

        [HttpPut]
        [Route("{id}")]
        //[Authorize(Roles = "Admin")]
        public async Task<IActionResult> Update([FromRoute][Required] int id, BlogUpdateDto blogUpdateDto)
        {
            try
            {
                await _blogService.UpdateAsync(id, blogUpdateDto);

                return Ok(blogUpdateDto);
            }
            catch (NullReferenceException)
            {
                return NotFound();
            }
        }

        [HttpDelete]
        //[Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete([Required] int id)
        {
            try
            {
                await _blogService.DeleteAsync(id);
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
                await _blogService.SoftDeleteAsync(id);
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
            return Ok(await _blogService.GetAllAsync());
        }

        [HttpGet]
        public async Task<IActionResult> GetRecentBlogs()
        {
            return Ok( await _blogService.GetRecentBlogsAsync());
        }

        [HttpGet]
        public async Task<IActionResult> Get([Required] int id)
        {
            try
            {
                return Ok(await _blogService.GetByIdAsync(id));
            }
            catch (NullReferenceException)
            {
                return NotFound();
            }
        }

    }
}
