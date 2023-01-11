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

            if (link is null) throw new NullReferenceException(nameof(link));

            _emailService.Register(registerDto, link);

            return Ok();
        }


        [HttpGet]       
        public async Task<IActionResult> ConfirmEmail(string userId, string token)
        {
            await _accountService.ConfirmEmailAsync(userId, token);
            return Redirect("http://localhost:3000/");
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
            string url = "http://localhost:3001/forgotpassword/" + user.Email + "/token=" + forgotpasswordtoken;
            _emailService.ForgotPassword(user, url, forgotPassword);

            return Ok();
        }


        [HttpPost]        
        public async Task<IActionResult> ResetPassword(ResetPasswordDto resetPassworddto)
        {

            var user = await _userManager.FindByEmailAsync(resetPassworddto.Email);

            if (user is null) return NotFound();

            await _userManager.ResetPasswordAsync(user, resetPassworddto.Token, resetPassworddto.Password);

            return Ok();
        }

        [HttpGet]
        [Route("{email}")]
        public async Task<UserDto> GetUserByEmail([FromRoute] string email)
        {
            var user = await _accountService.GetUserByEmailAsync(email);

            return user;
        }


        [HttpPut]
        [Route("{email}")]
        public async Task<IActionResult> UpdatePassword([FromRoute] string email, [FromBody] UpdatePasswordDto updatePasswordDto)
        {
            AppUser appUser = await _userManager.FindByEmailAsync(email);
            await _accountService.UpdatePasswordAsync(appUser, updatePasswordDto);
            return Ok();
        }


        [HttpPut]
        [Route("{email}")]
        public async Task<IActionResult> UpdateUser([FromRoute] string email, [FromBody] UpdateUserDto updateUserDto)
        {
            AppUser appUser = await _userManager.FindByEmailAsync(email);
            await _accountService.UpdateUserAsync(appUser, updateUserDto);
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
