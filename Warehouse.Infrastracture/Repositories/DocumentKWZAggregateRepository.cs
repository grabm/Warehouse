using Warehouse.Domain;
using Warehouse.Infrastructure.EntityFramework;

namespace Warehouse.Infrastructure.Repositories
{
    public class DocumentKWZAggregateRepository : BaseAggregateRepository<DocumentKWZ>
    {
        public DocumentKWZAggregateRepository(WarehouseDbContext context) : base(context)
        {
        }
    }
}