using Microsoft.AspNetCore.Mvc;
using Service.Services.DTOs.AppUser;
using Service.Services.Interfaces;

namespace Movflix.Controllers
{
    public class AccountController : AppController
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpPost]
        public async Task<IActionResult> Register([FromBody] RegisterDto registerDto)
        {
            await _accountService.RegisterAsync(registerDto);
            return Ok();
        }

        [HttpPost]
       
        public async Task<string?> Login([FromBody] LoginDto loginDto)
        {
            return await _accountService.LoginAsync(loginDto);
        }
    }
}
