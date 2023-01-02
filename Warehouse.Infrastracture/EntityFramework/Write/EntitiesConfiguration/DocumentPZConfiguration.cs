using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Warehouse.Domain;

namespace Warehouse.Infrastructure.EntityFramework.Write.EntitiesConfiguration
{
    public class DocumentPZConfiguration : IEntityTypeConfiguration<DocumentPZ>
    {
        public void Configure(EntityTypeBuilder<DocumentPZ> builder)
        {
            builder.Property(x => x.DocumentNumber)
                .HasMaxLength(500)
                .IsRequired();

            builder.HasOne<DocumentKPZ>()
            .WithOne()
            .HasForeignKey<DocumentKPZ>(x => x.DocumentPZId)
            .OnDelete(DeleteBehavior.ClientCascade);
        }
    }
}