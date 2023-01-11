using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.Services.DTOs.Pricing;
using Service.Services.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace Movflix.Controllers
{
    public class PricingController : AppController
    {
        private readonly IPricingService _pricingService;
        public PricingController(IPricingService pricingService)
        {
            _pricingService = pricingService;
        }
        [HttpPost]
        [Authorize(Roles = "Admin")]

        public async Task<IActionResult> Create([FromBody] PricingCreateDto pricingCreateDto)
        {
            await _pricingService.CreateAsync(pricingCreateDto);

            return Ok();
        }

        [HttpPut]
        [Route("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Update([FromRoute][Required] int id, PricingUpdateDto pricingUpdateDto)
        {
            try
            {
                await _pricingService.UpdateAsync(id, pricingUpdateDto);

                return Ok(pricingUpdateDto);
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
                await _pricingService.DeleteAsync(id);
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
            return Ok(await _pricingService.GetAllAsync());
        }


        [HttpGet]
        public async Task<IActionResult> Get([Required] int id)
        {
            try
            {
                return Ok(await _pricingService.GetAsync(id));
            }
            catch (NullReferenceException)
            {
                return NotFound();
            }
        }

    }
}
