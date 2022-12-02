using Warehouse.Domain;

namespace Warehouse.Infrastructure.Repositories
{
    public class ContractorAggregateRepository : BaseRepository<Contractor>
    {
        public ContractorAggregateRepository(WarehouseDbContext context) : base(context)
        {
        }
    }
}