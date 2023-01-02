using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Domain;

namespace Warehouse.Infrastructure.EntityFramework.Write.EntitiesConfiguration
{
    public class DocumentWZConfiguration : IEntityTypeConfiguration<DocumentWZ>
    {
        public void Configure(EntityTypeBuilder<DocumentWZ> builder)
        {
            builder.Property(x => x.DocumentNumber)
                .HasMaxLength(500)
                .IsRequired();

            builder.HasOne<DocumentKWZ>()
            .WithOne()
            .HasForeignKey<DocumentKWZ>(x => x.DocumentWZId)
            .OnDelete(DeleteBehavior.ClientCascade);
        }
    }
}
