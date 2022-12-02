using Warehouse.Domain;

namespace Warehouse.Infrastructure.Repositories
{
    public class ProductAggregateRepository : BaseRepository<Product>
    {
        public ProductAggregateRepository(WarehouseDbContext context) : base(context)
        {
        }
    }
}