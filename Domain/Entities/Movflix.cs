using Domain.Common;

namespace Domain.Entities
{
    public class Movflix : BaseEntity
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Test { get; set; }
    }
}
