using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Warehouse.Domain;
using Warehouse.Infrastructure.EntityFramework.Write.EntitiesConfiguration;

namespace Warehouse.Infrastructure.EntityFramework.Write
{
    public class WarehouseWriteDbContext : DbContext
    {
        public WarehouseWriteDbContext(DbContextOptions<WarehouseWriteDbContext> options)
         : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Contractor> Contractors { get; set; }
        public DbSet<DocumentKPZ> KPZDocuments { get; set; }
        public DbSet<DocumentKWZ> KWZDocuments { get; set; }
        public DbSet<DocumentMM> MMDocuments { get; set; }
        public DbSet<DocumentPZ> PZDocuments { get; set; }
        public DbSet<DocumentWZ> WZDocuments { get; set; }
        public DbSet<MeasurementUnit> MeasurementUnits { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Domain.Region> Regions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //TODO dodać resztę konfiguracji
            modelBuilder.ApplyConfiguration(new RegionConfiguration());
            modelBuilder.ApplyConfiguration(new WarehouseConfiguration());
        }
    }
}