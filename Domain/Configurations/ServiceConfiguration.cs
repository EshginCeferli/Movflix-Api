using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Configurations
{
    public class ServiceConfiguration : IEntityTypeConfiguration<Servise>
    {
        public void Configure(EntityTypeBuilder<Servise> builder)
        {
            builder.Property(m => m.Image).IsRequired();

            builder.Property(m => m.CreateDate).HasDefaultValue(DateTime.UtcNow);
            builder.Property(m => m.SoftDeleted).HasDefaultValue(false);

            builder.HasQueryFilter(m => !m.SoftDeleted);
        }
    }
}
