using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Application.Abstractions;
using Warehouse.Domain;
using Warehouse.Domain.Abstraction;
using Warehouse.Infrastructure.EntityFramework.Write;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Warehouse.Infrastructure.Repositories
{
    public abstract class BaseAggregateRepository<T> : IAggregateRepository<T> where T : class, IAggregateRoot
    {
        protected WarehouseWriteDbContext _context;

        public BaseAggregateRepository(WarehouseWriteDbContext context)
        {
            _context = context;
        }

        public async Task<T> GetAsync(long id, params Expression<Func<T, object>>[] includes)
        {
            var regions = _context.Set<T>();
            foreach(var include in includes)
            {
                regions.Include(include);
            }

           return await regions.FindAsync(id);
        }
        public async Task CreateAsync(T entity)
        {
            _context.Add(entity);
            await SaveChangesAsync();
        }

        public Task SaveChangesAsync() => _context.SaveChangesAsync();
    }
}
