using Warehouse.Domain;
using Warehouse.Infrastructure.EntityFramework.Write;

namespace Warehouse.Infrastructure.Repositories
{
    public class ProductAggregateRepository : BaseAggregateRepository<Product>
    {
        public ProductAggregateRepository(WarehouseWriteDbContext context) : base(context)
        {
        }
    }
}