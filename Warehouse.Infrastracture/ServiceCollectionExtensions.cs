using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Application.Abstractions;
using Warehouse.Domain;
using Warehouse.Domain.Abstraction;
using Warehouse.Infrastructure.EntityFramework.Read.Entities;
using Warehouse.Infrastructure.EntityFramework.Write;
using Warehouse.Infrastructure.Repositories;

namespace Warehouse.Infrastructure
{
    public static class ServiceCollectionExtensions
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<WarehouseWriteDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("Sql")));

            services.AddScoped<IAggregateRepository<Category>, CategoryAggregateRepository>();
            services.AddScoped<IAggregateRepository<DocumentPZ>, DocumentPZAggregateRepository>();
            services.AddScoped<IAggregateRepository<DocumentKPZ>, DocumentKPZAggregateRepository>();
            services.AddScoped<IAggregateRepository<Region>, RegionAggregateRepository>();
        }
    }
}
