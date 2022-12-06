using Warehouse.Domain;
using Warehouse.Infrastructure.EntityFramework;

namespace Warehouse.Infrastructure.Repositories
{
    public class ContractorAggregateRepository : BaseAggregateRepository<Contractor>
    {
        public ContractorAggregateRepository(WarehouseDbContext context) : base(context)
        {
        }
    }
}