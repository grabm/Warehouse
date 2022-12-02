using Warehouse.Domain;

namespace Warehouse.Infrastructure.Repositories
{
    internal class RegionAggregateRepository : BaseRepository<Region>
    {
        public RegionAggregateRepository(WarehouseDbContext context) : base(context)
        {
        }
    }
}