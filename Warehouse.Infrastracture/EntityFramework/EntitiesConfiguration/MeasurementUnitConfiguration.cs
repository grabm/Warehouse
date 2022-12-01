using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Warehouse.Domain;

namespace Warehouse.Infrastructure.EntityFramework.EntitiesConfiguration
{
    public class MeasurementUnitConfiguration : IEntityTypeConfiguration<MeasurementUnit>
    {
        public void Configure(EntityTypeBuilder<MeasurementUnit> builder)
        {
            builder.Property(x => x.Name)
                .HasMaxLength(10)
                .IsRequired();
        }
    }
}