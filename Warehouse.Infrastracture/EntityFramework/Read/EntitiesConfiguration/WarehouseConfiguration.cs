using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Warehouse.Domain;
using Warehouse.Infrastructure.EntityFramework.Read.Entities;

namespace Warehouse.Infrastructure.EntityFramework.Read.EntitiesConfiguration
{
    public class WarehouseConfiguration : IEntityTypeConfiguration<Entities.Warehouse>
    {
        public void Configure(EntityTypeBuilder<Entities.Warehouse> builder)
        {
            builder.Property(x => x.Name)
                .HasMaxLength(300)
                .IsRequired();

            builder.OwnsOne(x => x.Address);

            builder.HasMany<Product>()
                .WithOne()
                .HasForeignKey(x => x.WarehouseId);
        }
    }
}