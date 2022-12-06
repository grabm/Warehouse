using Warehouse.Domain;
using Warehouse.Infrastructure.EntityFramework;

namespace Warehouse.Infrastructure.Repositories
{
    public class DocumentKPZAggregateRepository : BaseAggregateRepository<DocumentKPZ>
    {
        public DocumentKPZAggregateRepository(WarehouseDbContext context) : base(context)
        {
        }
    }
}