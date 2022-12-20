using Domain.Entities;

namespace Repository.Interfaces
{
    public interface IMovieCategoryRepository : IRepository<MovieCategory>
    {
        Task<List<MovieCategory>> GetAllCategories();
    }
}
