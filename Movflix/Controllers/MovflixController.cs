using Microsoft.AspNetCore.Mvc;
using Service.Services.DTOs.Movflix;
using Service.Services.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Movflix.Controllers
{
    public class MovflixController : AppController
    {
        private readonly IMovflixService _movflixService;

        public MovflixController(IMovflixService movflixService)
        {
            _movflixService = movflixService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _movflixService.GetAllAsync());
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] MovflixCreateDto movflixCreateDto)
        {
            await _movflixService.CreateAsync(movflixCreateDto);
            return Ok();
        }

        [HttpPost]
        [Route("{id}")]
        public async Task<IActionResult> Update([FromRoute][Required] int id, MovflixUpdateDto movflixUpdateDto)
        {
            await _movflixService.UpdateAsync(id, movflixUpdateDto);
            return Ok(movflixUpdateDto);
        }
    }
}
