using Warehouse.Domain;
using Warehouse.Domain.ReadModels;
using Warehouse.Infrastructure.EntityFramework.Write;

namespace Warehouse.Infrastructure.Repositories
{
    internal class RegionAggregateRepository : BaseAggregateRepository<Domain.Region>
    {
        public RegionAggregateRepository(WarehouseWriteDbContext context) : base(context)
        {
        }
    }
}