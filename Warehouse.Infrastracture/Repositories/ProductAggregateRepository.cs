using Warehouse.Domain;
using Warehouse.Infrastructure.EntityFramework;

namespace Warehouse.Infrastructure.Repositories
{
    public class ProductAggregateRepository : BaseAggregateRepository<Product>
    {
        public ProductAggregateRepository(WarehouseDbContext context) : base(context)
        {
        }
    }
}