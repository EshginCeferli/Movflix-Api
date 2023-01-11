using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Configurations
{
    public class MovieConfiguration : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.Property(m => m.Name).IsRequired();
            //builder.Property(m => m.Poster).IsRequired();
            builder.Property(m => m.Country).IsRequired();
            builder.Property(m => m.Description).IsRequired();
            builder.Property(m => m.Length).IsRequired();
            builder.Property(m => m.ReleaseYear).IsRequired();
            builder.Property(m => m.Photo).IsRequired();
            builder.Property(m => m.SoftDeleted).HasDefaultValue(false);
            builder.Property(m => m.CreateDate).HasDefaultValue(DateTime.UtcNow);

            builder.HasQueryFilter(m => !m.SoftDeleted);
        }
    }
}
