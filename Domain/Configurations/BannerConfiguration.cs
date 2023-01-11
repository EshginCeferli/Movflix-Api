using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Domain.Configurations
{
    public class BannerConfiguration : IEntityTypeConfiguration<Banner>
    {
        public void Configure(EntityTypeBuilder<Banner> builder)
        {

            builder.Property(m => m.CreateDate).HasDefaultValue(DateTime.UtcNow);
            builder.Property(m => m.SoftDeleted).HasDefaultValue(false);

            builder.Property(m => m.Image).IsRequired();


            builder.HasQueryFilter(m => !m.SoftDeleted);
        }
    }
}
