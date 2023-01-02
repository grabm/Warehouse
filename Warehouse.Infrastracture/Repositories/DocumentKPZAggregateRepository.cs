using Warehouse.Domain;
using Warehouse.Infrastructure.EntityFramework.Write;

namespace Warehouse.Infrastructure.Repositories
{
    public class DocumentKPZAggregateRepository : BaseAggregateRepository<DocumentKPZ>
    {
        public DocumentKPZAggregateRepository(WarehouseWriteDbContext context) : base(context)
        {
        }
    }
}