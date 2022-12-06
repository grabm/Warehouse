using Warehouse.Domain;
using Warehouse.Infrastructure.EntityFramework;

namespace Warehouse.Infrastructure.Repositories
{
    public class MeasurementUnitAggregateRepository : BaseAggregateRepository<MeasurementUnit>
    {
        public MeasurementUnitAggregateRepository(WarehouseDbContext context) : base(context)
        {
        }
    }
}