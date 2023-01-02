using Warehouse.Domain;
using Warehouse.Infrastructure.EntityFramework.Write;

namespace Warehouse.Infrastructure.Repositories
{
    public class ContractorAggregateRepository : BaseAggregateRepository<Contractor>
    {
        public ContractorAggregateRepository(WarehouseWriteDbContext context) : base(context)
        {
        }
    }
}