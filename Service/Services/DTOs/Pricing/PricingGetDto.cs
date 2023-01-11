using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.DTOs.Pricing
{
    public class PricingGetDto
    {
        public string? Name { get; set; }
        public float Price { get; set; }
        public string? Quality { get; set; }
        public string? Resolution { get; set; }
        public int Screen { get; set; }
    }
}
