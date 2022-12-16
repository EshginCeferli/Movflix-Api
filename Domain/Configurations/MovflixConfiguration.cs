﻿using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace Domain.Configurations
{
    public class MovflixConfiguration : IEntityTypeConfiguration<Movflix>
    {
        public void Configure(EntityTypeBuilder<Movflix> builder)
        {
            builder.Property(m => m.Name).IsRequired().HasMaxLength(100);
            builder.Property(m => m.CreateDate).HasDefaultValue(DateTime.UtcNow);
            builder.Property(m => m.Description).IsRequired();          
          
            builder.HasQueryFilter(m => !m.SoftDeleted);
        }
    }


}
