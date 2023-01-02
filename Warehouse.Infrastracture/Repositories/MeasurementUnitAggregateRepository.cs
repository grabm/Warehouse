using Warehouse.Domain;
using Warehouse.Infrastructure.EntityFramework.Write;

namespace Warehouse.Infrastructure.Repositories
{
    public class MeasurementUnitAggregateRepository : BaseAggregateRepository<MeasurementUnit>
    {
        public MeasurementUnitAggregateRepository(WarehouseWriteDbContext context) : base(context)
        {
        }
    }
}