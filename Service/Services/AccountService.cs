using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Service.Services.DTOs.AppUser;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class AccountService : IAccountService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IMapper _mapper;
        private readonly ITokenService _tokenService;


        public AccountService(UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager, IMapper mapper, ITokenService tokenService)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _mapper = mapper;
            _tokenService= tokenService;
            
        }

        public async Task<string?> LoginAsync(LoginDto loginDto)
        {
            var user = await _userManager.FindByEmailAsync(loginDto.Email);

            if (user is null) return null;

            if (!await _userManager.CheckPasswordAsync(user, loginDto.Password)) return null;

            var roles = await _userManager.GetRolesAsync(user);

            string token =  _tokenService.GenerateJwtToken(user.Email, user.UserName, (List<string>)roles);

            return token;
        }

        public async Task RegisterAsync(RegisterDto registerDto)
        {
            var user = _mapper.Map<AppUser>(registerDto);

            if (user == null) throw new NullReferenceException();

            await _userManager.CreateAsync(user, registerDto.Password);

           


            //await _userManager.AddToRoleAsync(user, "User");

        }


    }
}
