using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Warehouse.Domain;

namespace Warehouse.Infrastructure.EntityFramework.Write.EntitiesConfiguration
{
    public class DocumentMMConfiguration : IEntityTypeConfiguration<DocumentMM>
    {
        public void Configure(EntityTypeBuilder<DocumentMM> builder)
        {
            builder.Property(x => x.DocumentNumber)
                .HasMaxLength(500)
                .IsRequired();

        }
    }
}