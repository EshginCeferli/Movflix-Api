using Domain.Common;

namespace Domain.Entities
{
    public class Comment : BaseEntity
    {
        public string By { get; set; }
        public string Context { get; set; }
        public int BlogId { get; set; }
        public Blog? Blog { get; set; }

    }
}
