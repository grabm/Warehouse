using Warehouse.Domain;
using Warehouse.Infrastructure.EntityFramework;

namespace Warehouse.Infrastructure.Repositories
{
    public class DocumentMMAggregateRepository : BaseAggregateRepository<DocumentMM>
    {
        public DocumentMMAggregateRepository(WarehouseDbContext context) : base(context)
        {
        }
    }
}