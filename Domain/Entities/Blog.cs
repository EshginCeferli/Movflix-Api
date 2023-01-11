using Domain.Common;

namespace Domain.Entities
{
    public class Blog : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Intro { get; set; }
        public string By { get; set; }
        public byte[]? Photo { get; set; }
        public List<BlogImage>? BlogImages { get; set; }
        public List<Comment>? Comments { get; set; }
    }
}
