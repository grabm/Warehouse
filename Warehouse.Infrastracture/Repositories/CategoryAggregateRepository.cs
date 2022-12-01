using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Application.Abstractions;
using Warehouse.Domain;

namespace Warehouse.Infrastructure.Repositories
{
    internal class CategoryAggregateRepository : IAggregateRepository<Category>
    {
        private WarehouseDbContext _context;

        public CategoryAggregateRepository(WarehouseDbContext context)
        {
            _context = context;
        }

        public async Task<Category> GetAsync(long id)
        {
           return await _context.Categories.FirstOrDefaultAsync(x => x.Id == id);
        }

        public Task SaveChangesAsync() => _context.SaveChangesAsync();
    }
}
