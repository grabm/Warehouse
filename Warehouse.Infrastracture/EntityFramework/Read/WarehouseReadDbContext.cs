using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Warehouse.Infrastructure.EntityFramework.Read.Entities;
using Warehouse.Infrastructure.EntityFramework.Read.EntitiesConfiguration;

namespace Warehouse.Infrastructure.EntityFramework.Read
{
    public class WarehouseReadDbContext : DbContext
    {
        public WarehouseReadDbContext(DbContextOptions<WarehouseReadDbContext> options)
         : base(options)
        {
        }

        public DbSet<Entities.Warehouse> Warehouse { get; set; }
        public DbSet<Region> Regions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new RegionConfiguration());
            modelBuilder.ApplyConfiguration(new WarehouseConfiguration());
        }
    }
}