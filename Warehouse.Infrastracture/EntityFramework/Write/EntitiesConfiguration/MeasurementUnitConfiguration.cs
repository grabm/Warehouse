using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Warehouse.Domain;

namespace Warehouse.Infrastructure.EntityFramework.Write.EntitiesConfiguration
{
    public class MeasurementUnitConfiguration : IEntityTypeConfiguration<MeasurementUnit>
    {
        public void Configure(EntityTypeBuilder<MeasurementUnit> builder)
        {
            builder.Property(x => x.Name)
                .HasMaxLength(10)
                .IsRequired();

            builder.HasMany<Product>()
                .WithOne()
                .HasForeignKey(x => x.MeasurementUnitId);

        }
    }
}