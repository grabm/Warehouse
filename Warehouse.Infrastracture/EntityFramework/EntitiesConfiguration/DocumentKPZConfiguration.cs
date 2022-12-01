using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Warehouse.Domain;

namespace Warehouse.Infrastructure.EntityFramework.EntitiesConfiguration
{
    public class DocumentKPZConfiguration : IEntityTypeConfiguration<DocumentKPZ>
    {
        public void Configure(EntityTypeBuilder<DocumentKPZ> builder)
        {
            builder.Property(x => x.DocumentNumber)
                .HasMaxLength(500)
                .IsRequired();

        }
    }
}