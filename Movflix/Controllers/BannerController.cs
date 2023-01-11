using Microsoft.AspNetCore.Mvc;
using Service.Services.DTOs.Blog;
using Service.Services;
using Service.Services.Interfaces;
using Service.Services.DTOs.Banner;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authorization;

namespace Movflix.Controllers
{
    public class BannerController : AppController
    {
        private readonly IBannerService _bannerService;
        public BannerController(IBannerService bannerService)
        {
            _bannerService = bannerService;
        }
        [HttpPost]
        [Authorize(Roles = "Admin")]

        public async Task<IActionResult> Create([FromBody] BannerCreateDto bannerCreateDto)
        {
            await _bannerService.CreateAsync(bannerCreateDto);

            return Ok();
        }

        [HttpPut]
        [Route("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Update([FromRoute][Required] int id, BannerUpdateDto bannerUpdateDto)
        {
            try
            {
                await _bannerService.UpdateAsync(id, bannerUpdateDto);

                return Ok(bannerUpdateDto);
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
                await _bannerService.DeleteAsync(id);
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
            return Ok(await _bannerService.GetAllAsync());
        }


        [HttpGet]
        public async Task<IActionResult> Get([Required] int id)
        {
            try
            {
                return Ok(await _bannerService.GetAsync(id));
            }
            catch (NullReferenceException)
            {
                return NotFound();
            }
        }

    }
}
