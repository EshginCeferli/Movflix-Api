using Domain.Entities;
using MailKit.Security;
using Microsoft.AspNetCore.Identity;
using MimeKit.Text;
using MimeKit;
using Service.Services.DTOs.AppUser;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailKit.Net.Smtp;

namespace Service.Services
{
    public class EmailService : IEmailService
    {
        private readonly UserManager<AppUser> _userManager;
      

        public EmailService(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
      

        }

        public async Task ConfirmEmail(string userId, string token)
        {
            AppUser user = await _userManager.FindByIdAsync(userId);

            await _userManager.ConfirmEmailAsync(user, token);
        }


        public void Register(RegisterDto registerDto, string link)
        {
            var message = new MimeMessage();
            message.From.Add(MailboxAddress.Parse("eceferli98@gmail"));
            message.To.Add(MailboxAddress.Parse(registerDto.Email));
            message.Subject = "Confirm Email";
            string emailbody = string.Empty;

            using (StreamReader streamReader = new StreamReader("wwwroot/Templates/Confirm.html"))
            {
                emailbody = streamReader.ReadToEnd();
            }

            emailbody = emailbody.Replace("{{code}}", $"{link}").Replace("{{fullname}}", $"{registerDto.FullName}");
            message.Body = new TextPart(TextFormat.Html) { Text = emailbody };

            using var smtp = new SmtpClient();
            smtp.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
            smtp.Authenticate("eceferli98@gmail.com", "hnzsizoxnzmcdmfj");
            smtp.Send(message);
            smtp.Disconnect(true);
        }

        public void ForgotPassword(AppUser user, string url, ForgotPasswordDto forgotPassword)
        {
            var message = new MimeMessage();

            message.From.Add(MailboxAddress.Parse("eceferli98@gmail"));

            message.To.Add(MailboxAddress.Parse(forgotPassword.Email));

            message.Subject = "Reset Password";

            string emailbody = string.Empty;

            using (StreamReader streamReader = new StreamReader("wwwroot/Templates/Confirm.html"))
            {
                emailbody = streamReader.ReadToEnd();
            }

            emailbody = emailbody.Replace("{{fullname}}", $"{user.FullName}").Replace("{{code}}", $"{url}");

            message.Body = new TextPart(TextFormat.Html) { Text = emailbody };

            using var smtp = new SmtpClient();

            smtp.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
            smtp.Authenticate("eceferli98@gmail.com", "hnzsizoxnzmcdmfj");
            smtp.Send(message);
            smtp.Disconnect(true);
        }

    }
}
