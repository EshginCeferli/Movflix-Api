using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Service.Services.DTOs.AppUser;
using Service.Services.Interfaces;

namespace Movflix.Controllers
{
    public class AccountController : AppController
    {
        private readonly IAccountService _accountService;
        private readonly UserManager<AppUser> _userManager;
        private readonly IEmailService _emailService;


        public AccountController(IAccountService accountService, UserManager<AppUser> userManager, IEmailService emailService)
        {
            _accountService = accountService;
            _userManager = userManager;
            _emailService = emailService;
        }

        [HttpPost]
        public async Task<IActionResult> Register([FromBody] RegisterDto registerDto)
        {
            await _accountService.RegisterAsync(registerDto);
            var appUser = await _userManager.FindByEmailAsync(registerDto.Email);
            var token = await _userManager.GenerateEmailConfirmationTokenAsync(appUser);
            var link = Url.Action(nameof(ConfirmEmail), "Account", new { userId = appUser.Id, token }, Request.Scheme, Request.Host.ToString());
            _emailService.Register(registerDto, link);

            return Ok();
        }


        [HttpGet]       
        public async Task<IActionResult> ConfirmEmail(string userId, string token)
        {
            await _accountService.ConfirmEmail(userId, token);
            return Redirect("https://localhost:7079/swagger/index.html");
        }

        [HttpPost]
       
        public async Task<string?> Login([FromBody] LoginDto loginDto)
        {
            return await _accountService.LoginAsync(loginDto);
        }

        [HttpPost]       
        public async Task<IActionResult> ForgotPassword([FromBody] ForgotPasswordDto forgotPassword)
        {
            var user = await _userManager.FindByEmailAsync(forgotPassword.Email);

            if (user is null) throw new ArgumentNullException();

            string forgotpasswordtoken = await _userManager.GeneratePasswordResetTokenAsync(user);
            string url = "https://localhost:7079/forgotpassword/" + user.Email + "/token=" + forgotpasswordtoken;
            _emailService.ForgotPassword(user, url, forgotPassword);

            return Ok();
        }


        [HttpPost]
        public async Task<IActionResult> CreateRole([FromBody] RoleDto roleDto)
        {
            await  _accountService.CreateRoleAsync(roleDto);
            return Ok();
        }
    }
}
