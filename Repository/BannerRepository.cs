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
    public class BannerRepository : Repository<Banner>, IBannerRepository
    {
        public BannerRepository(AppDbContext context) : base(context) { }

    }
}
