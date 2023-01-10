using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.Services.DTOs.Blog;
using Service.Services;
using Service.Services.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.Data;
using Service.Services.DTOs.Contact;

namespace Movflix.Controllers
{
    public class ContactController : AppController
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService= contactService;
        }

        [HttpPut]
        [Route("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Update([FromRoute][Required] int id, ContactUpdateDto contactUpdateDto)
        {
            try
            {
                await _contactService.UpdateAsync(id, contactUpdateDto);

                return Ok(contactUpdateDto);
            }
            catch (NullReferenceException)
            {
                return NotFound();
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _contactService.GetAllAsync());
        }

        [HttpGet]
        public async Task<IActionResult> Get([Required]int id)
        {
            return Ok(await _contactService.GetAsync(id));
        }
    }
}
