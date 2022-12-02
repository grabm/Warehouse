﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Warehouse.Domain;

namespace Warehouse.Infrastructure.EntityFramework.EntitiesConfiguration
{
    public class RegionConfiguration : IEntityTypeConfiguration<Region>
    {
        public void Configure(EntityTypeBuilder<Region> builder)
        {
            builder.Property(x => x.Name)
                .HasMaxLength(300)
                .IsRequired();

            builder.HasMany(x => x.Warehouses)
                .WithOne()
                .HasForeignKey(x => x.RegionId);
        }
    }
}