using Domain.Common;
using Microsoft.EntityFrameworkCore;
using Repository.Data;
using Repository.Interfaces;
using System.Linq.Expressions;

namespace Repository
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly AppDbContext _context;
        private readonly DbSet<T> _entities;

        public Repository(AppDbContext context)
        {
            _context = context;
            _entities = _context.Set<T>();
        }

        public async Task CreateAsync(T entity)
        {
            if (entity == null) throw new ArgumentNullException();

            await _entities.AddAsync(entity);

            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            if (entity == null) throw new ArgumentNullException();

            _entities.Remove(entity);

            await _context.SaveChangesAsync();

        }

        public async Task<T> GetAsync(int id)
        {
            return await _entities.FindAsync(id) ?? throw new NullReferenceException();
        }

        public async Task SoftDeleteAsync(T entity)
        {
            T? model = await _entities.FirstOrDefaultAsync(m => m.Id == entity.Id);

            if (model == null) throw new NullReferenceException();

            model.SoftDeleted = true;

            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            if (entity == null) throw new ArgumentNullException();

            _entities.Update(entity);

            await _context.SaveChangesAsync();
        }

        async Task<List<T>> IRepository<T>.GetAllAsync()
        {
            return await _entities.ToListAsync();
        }

        public async Task<List<T>> FindAllByExpressionAsync(Expression<Func<T, bool>> expression)
        {
            return await _entities.Where(expression).ToListAsync();
        }
    }
}
