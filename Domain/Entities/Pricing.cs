using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Pricing : BaseEntity
    {
        public string? Name { get; set; }
        public float Price { get; set; }
        public string? Quality { get; set; }
        public string? Resolution { get; set; }
        public int Screen { get; set; }
    }
}
