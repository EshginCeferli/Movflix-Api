using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.Services.DTOs.Banner;
using Service.Services.DTOs.Service;
using Service.Services.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace Movflix.Controllers
{
    public class ServiseController : AppController
    {
        private readonly IServiseService _service;
        public ServiseController(IServiseService service)
        {
            _service = service;
        }
        [HttpPost]
        [Authorize(Roles = "Admin")]

        public async Task<IActionResult> Create([FromBody] ServiceCreateDto serviceCreateDto)
        {
            await _service.CreateAsync(serviceCreateDto);

            return Ok();
        }

        [HttpPut]
        [Route("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Update([FromRoute][Required] int id, ServiceUpdateDto serviceUpdateDto)
        {
            try
            {
                await _service.UpdateAsync(id, serviceUpdateDto);

                return Ok(serviceUpdateDto);
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
                await _service.DeleteAsync(id);
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
            return Ok(await _service.GetAllAsync());
        }


        [HttpGet]
        public async Task<IActionResult> Get([Required] int id)
        {
            try
            {
                return Ok(await _service.GetAsync(id));
            }   
            catch (NullReferenceException)
            {
                return NotFound();
            }
        }

    }
}
