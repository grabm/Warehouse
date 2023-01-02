using Warehouse.Domain;
using Warehouse.Infrastructure.EntityFramework.Write;

namespace Warehouse.Infrastructure.Repositories
{
    public class DocumentWZAggregateRepository : BaseAggregateRepository<DocumentWZ>
    {
        public DocumentWZAggregateRepository(WarehouseWriteDbContext context) : base(context)
        {
        }
    }
}