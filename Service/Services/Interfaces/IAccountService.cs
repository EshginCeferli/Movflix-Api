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
        Task<string?> LoginAsync(LoginDto loginDto);

    }
}
