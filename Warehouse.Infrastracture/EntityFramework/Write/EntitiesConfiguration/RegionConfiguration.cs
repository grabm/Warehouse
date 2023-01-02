using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Warehouse.Domain;
using Warehouse.Domain.ReadModels;

namespace Warehouse.Infrastructure.EntityFramework.Write.EntitiesConfiguration
{
    public class RegionConfiguration : IEntityTypeConfiguration<Domain.Region>
    {
        public void Configure(EntityTypeBuilder<Domain.Region> builder)
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