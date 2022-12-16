﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    public interface IMovieRepository :IRepository<Movie>
    {
        Task<List<Movie>> GetAllMoviesWithCategories();
    }
}
