using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Application.Abstractions;
using Warehouse.Domain;
using Warehouse.Domain.Abstraction;

namespace Warehouse.Infrastructure.Repositories
{
    public abstract class BaseRepository<T>: IAggregateRepository<T> where T : class, IAggregateRoot
    {
        protected WarehouseDbContext _context;

        public BaseRepository(WarehouseDbContext context)
        {
            _context = context;
        }

        public async Task<T> GetAsync(long id) => await _context.Set<T>().FindAsync(id);

        public Task SaveChangesAsync() => _context.SaveChangesAsync();
    }
}
