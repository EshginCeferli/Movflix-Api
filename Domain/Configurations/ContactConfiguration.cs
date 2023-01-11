using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Configurations
{
    public class ContactCongiguration : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.Property(m => m.Address).IsRequired();
            builder.Property(m => m.Phone).IsRequired();
            builder.Property(m => m.Email).IsRequired();

            builder.Property(m => m.CreateDate).HasDefaultValue(DateTime.UtcNow);
            builder.Property(m => m.SoftDeleted).HasDefaultValue(false);


            builder.HasQueryFilter(m => !m.SoftDeleted);
        }
    }
}
