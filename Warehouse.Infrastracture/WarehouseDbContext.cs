using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Warehouse.Domain;
using Warehouse.Infrastructure.EntityFramework.EntitiesConfiguration;

namespace Warehouse.Infrastructure
{
    public class WarehouseDbContext: DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contractor> Contractors { get; set; }
        public DbSet<DocumentKPZ> KPZDocuments { get; set; }
        public DbSet<DocumentKWZ> KWZDocuments { get; set; }
        public DbSet<DocumentMM> MMDocuments { get; set; }
        public DbSet<DocumentPZ> PZDocuments { get; set; }
        public DbSet<DocumentWZ> WZDocuments { get; set; }
        public DbSet<MeasurementUnit> MeasurementUnits { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Region> Regions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //--Bulk registration
            modelBuilder.ApplyConfigurationsFromAssembly(
                Assembly.GetAssembly(typeof(WarehouseDbContext)
                ));
        }
    }
}