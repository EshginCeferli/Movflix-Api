using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Configurations
{
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.Property(m => m.By).IsRequired();
            builder.Property(m => m.Context).IsRequired();


            builder.Property(m => m.SoftDeleted).HasDefaultValue(false);
            builder.Property(m => m.CreateDate).HasDefaultValue(DateTime.UtcNow.ToLongDateString());

            builder.HasQueryFilter(m => !m.SoftDeleted);
        }
    }
}

