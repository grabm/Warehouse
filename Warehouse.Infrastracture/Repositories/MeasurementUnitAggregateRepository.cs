using Warehouse.Domain;

namespace Warehouse.Infrastructure.Repositories
{
    public class MeasurementUnitAggregateRepository : BaseRepository<MeasurementUnit>
    {
        public MeasurementUnitAggregateRepository(WarehouseDbContext context) : base(context)
        {
        }
    }
}