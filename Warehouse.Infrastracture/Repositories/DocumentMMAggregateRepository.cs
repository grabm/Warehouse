using Warehouse.Domain;
using Warehouse.Infrastructure.EntityFramework.Write;

namespace Warehouse.Infrastructure.Repositories
{
    public class DocumentMMAggregateRepository : BaseAggregateRepository<DocumentMM>
    {
        public DocumentMMAggregateRepository(WarehouseWriteDbContext context) : base(context)
        {
        }
    }
}