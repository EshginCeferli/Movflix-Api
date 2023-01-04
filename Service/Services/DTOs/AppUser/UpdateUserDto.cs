using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.DTOs.AppUser
{
    public class UpdateUserDto
    {
        public string PhoneNumber { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }
    }
}
