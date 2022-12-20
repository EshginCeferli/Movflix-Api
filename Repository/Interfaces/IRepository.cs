using Domain.Common;
using System.Linq.Expressions;

namespace Repository.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetAsync(int id);
        Task CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task SoftDeleteAsync(T entity);
        Task DeleteAsync(T entity);
        Task<List<T>> FindAllByExpressionAsync(Expression<Func<T, bool>> expression);
    }
}
