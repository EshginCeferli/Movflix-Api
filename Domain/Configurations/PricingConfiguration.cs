using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Configurations
{
    public class PricingConfiguration : IEntityTypeConfiguration<Pricing>
    {
        public void Configure(EntityTypeBuilder<Pricing> builder)
        {
            builder.Property(m => m.Name).IsRequired();
            builder.Property(m => m.Quality).IsRequired();
            builder.Property(m => m.Screen).IsRequired();
            builder.Property(m => m.Price).IsRequired();
            builder.Property(m => m.Resolution).IsRequired();        
            builder.Property(m => m.SoftDeleted).HasDefaultValue(false);
            builder.Property(m => m.CreateDate).HasDefaultValue(DateTime.UtcNow);

            builder.HasQueryFilter(m => !m.SoftDeleted);
        }
    }
}
