using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Repository.Data;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class MovieCommentRepository : Repository<MovieComment>, IMovieCommentRepository
    {
        private readonly AppDbContext _context;
        private readonly DbSet<MovieComment> _entities;
        public MovieCommentRepository(AppDbContext context) : base(context)
        {
            _context = context;
            _entities = _context.Set<MovieComment>();
        }
    }
}
