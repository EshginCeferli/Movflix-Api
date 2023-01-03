using Domain.Entities;
using Service.Services.DTOs.AppUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Interfaces
{
    public interface IEmailService
    {
        void Register(RegisterDto registerDto, string link);
        Task ConfirmEmail(string userId, string token);
        void ForgotPassword(AppUser user, string url, ForgotPasswordDto forgotPassword);

    }
}
