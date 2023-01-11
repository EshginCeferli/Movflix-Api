using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.DTOs.Service
{
    public class ServiceListDto
    {
        public int Id { get; set; }
        public byte[] Image { get; set; }
        public string CreateDate { get; set; }
    }
}
