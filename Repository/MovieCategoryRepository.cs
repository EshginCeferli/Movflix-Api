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
    public class MovieCategoryRepository : Repository<MovieCategory> , IMovieCategoryRepository
    {
        public MovieCategoryRepository(AppDbContext context) : base(context) { }
       
    }
}
