using Domain.Common;

namespace Domain.Entities
{
    public class BlogImage : BaseEntity
    {
        public string? Image { get; set; }
        public bool IsMain { get; set; }
        public int BlogId { get; set; }
        public Blog? Blog { get; set; }
    }
}
