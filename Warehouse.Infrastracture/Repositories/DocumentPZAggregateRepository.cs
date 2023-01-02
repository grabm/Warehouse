using Warehouse.Domain;
using Warehouse.Infrastructure.EntityFramework.Write;

namespace Warehouse.Infrastructure.Repositories
{
    public class DocumentPZAggregateRepository : BaseAggregateRepository<DocumentPZ>
    {
        public DocumentPZAggregateRepository(WarehouseWriteDbContext context) : base(context)
        {
        }
    }
}