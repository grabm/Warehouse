using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Warehouse.Infrastructure.EntityFramework.EntitiesConfiguration
{
    public class WarehouseConfiguration : IEntityTypeConfiguration<Domain.Warehouse>
    {
        public void Configure(EntityTypeBuilder<Domain.Warehouse> builder)
        {
            builder.Property(x => x.Name)
                .HasMaxLength(300)
                .IsRequired();
        }
    }
}