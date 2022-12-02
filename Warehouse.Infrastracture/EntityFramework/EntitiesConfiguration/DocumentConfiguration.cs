using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Domain;

namespace Warehouse.Infrastructure.EntityFramework.EntitiesConfiguration
{
    internal class DocumentConfiguration : IEntityTypeConfiguration<Document>
    {
        public void Configure(EntityTypeBuilder<Document> builder)
        {
            builder.HasDiscriminator(x => x.DocumentType)
                .HasValue<DocumentKPZ>("KPZ")
                .HasValue<DocumentKWZ>("KWZ")
                .HasValue<DocumentMM>("MM")
                .HasValue<DocumentPZ>("PZ")
                .HasValue<DocumentWZ>("WZ");

            builder.HasMany(x => x.Items)
                .WithOne()
                .HasForeignKey(x => x.DocumentId);

        }
    }
}
