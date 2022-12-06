using Warehouse.Domain;
using Warehouse.Infrastructure.EntityFramework;

namespace Warehouse.Infrastructure.Repositories
{
    public class DocumentWZAggregateRepository : BaseAggregateRepository<DocumentWZ>
    {
        public DocumentWZAggregateRepository(WarehouseDbContext context) : base(context)
        {
        }
    }
}