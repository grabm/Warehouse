using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Domain;

namespace Warehouse.Infrastructure
{
    public class WarehouseDbContext: DbContext
    {
        private readonly MongoClient client;

        public WarehouseDbContext(MongoClient client)
        {
            this.client = client;
        }

        //public IQueryable<Product> Products => client.


        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //}

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //}


    }
}
