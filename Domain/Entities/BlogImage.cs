using Domain.Common;

namespace Domain.Entities
{
    public class BlogImage : BaseEntity
    {

        public byte[] Photo { get; set; }
        public bool IsMain { get; set; }
        public int BlogId { get; set; }
        public Blog? Blog { get; set; }
    }
}
