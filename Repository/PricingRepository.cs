using Domain.Entities;
using Repository.Data;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class PricingRepostory : Repository<Pricing>, IPricingRepository
    {
        public PricingRepostory(AppDbContext context) : base(context) { }

    }
}
