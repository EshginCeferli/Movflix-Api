using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Configurations
{
    public class MovflixConfiguration : IEntityTypeConfiguration<Movflix>
    {
        public void Configure(EntityTypeBuilder<Movflix> builder)
        {

            builder.Property(m => m.CreateDate).HasDefaultValue(DateTime.UtcNow);


            builder.HasQueryFilter(m => !m.SoftDeleted);
        }
    }


}
