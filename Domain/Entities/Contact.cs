using Domain.Common;

namespace Domain.Entities
{
    public class Contact : BaseEntity
    {
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
    }
}
