using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Warehouse.Domain;

namespace Warehouse.Infrastructure.EntityFramework.Write.EntitiesConfiguration
{
    public class DocumentKWZConfiguration : IEntityTypeConfiguration<DocumentKWZ>
    {
        public void Configure(EntityTypeBuilder<DocumentKWZ> builder)
        {
            builder.Property(x => x.DocumentNumber)
                .HasMaxLength(500)
                .IsRequired();

        }
    }
}