using Warehouse.Domain;
using Warehouse.Infrastructure.EntityFramework.Write;

namespace Warehouse.Infrastructure.Repositories
{
    public class DocumentKWZAggregateRepository : BaseAggregateRepository<DocumentKWZ>
    {
        public DocumentKWZAggregateRepository(WarehouseWriteDbContext context) : base(context)
        {
        }
    }
}