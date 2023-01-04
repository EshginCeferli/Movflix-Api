using Domain.Entities;
using Service.Services.DTOs.AppUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Interfaces
{
    public interface IAccountService
    {
        Task RegisterAsync(RegisterDto registerDto);
        Task ConfirmEmailAsync(string userId, string token);

        Task<string?> LoginAsync(LoginDto loginDto);
        Task<UserDto> GetUserByEmailAsync(string email);
        Task CreateRoleAsync(RoleDto roleDto);
        Task UpdatePasswordAsync(AppUser appUser, UpdatePasswordDto updatePasswordDto);
        Task UpdateUserAsync(AppUser appUser, UpdateUserDto updateuserDto);

    }
}
