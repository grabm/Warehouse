using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Warehouse.Domain;

namespace Warehouse.Infrastructure.EntityFramework.EntitiesConfiguration
{
    public class WarehouseConfiguration : IEntityTypeConfiguration<Domain.Warehouse>
    {
        public void Configure(EntityTypeBuilder<Domain.Warehouse> builder)
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