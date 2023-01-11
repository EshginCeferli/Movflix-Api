using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Configurations
{
    public class MovieCategoryConfiguration : IEntityTypeConfiguration<MovieCategory>
    {
        public void Configure(EntityTypeBuilder<MovieCategory> builder)
        {
            builder.Property(m => m.Name).IsRequired();

            builder.Property(m => m.SoftDeleted).HasDefaultValue(false);
            builder.Property(m => m.CreateDate).HasDefaultValue(DateTime.UtcNow);
            builder.HasQueryFilter(m => !m.SoftDeleted);
        }
    }
}
