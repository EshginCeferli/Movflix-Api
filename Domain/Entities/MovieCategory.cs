using Domain.Common;

namespace Domain.Entities
{
    public class MovieCategory : BaseEntity
    {
        public string? Name { get; set; }
        public List<Movie>? Movies { get; set; }
    }
}
