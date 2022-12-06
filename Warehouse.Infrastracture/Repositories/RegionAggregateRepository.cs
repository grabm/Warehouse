using Warehouse.Domain;
using Warehouse.Infrastructure.EntityFramework;

namespace Warehouse.Infrastructure.Repositories
{
    internal class RegionAggregateRepository : BaseAggregateRepository<Region>
    {
        public RegionAggregateRepository(WarehouseDbContext context) : base(context)
        {
        }
    }
}