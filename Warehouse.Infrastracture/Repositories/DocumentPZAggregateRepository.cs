using Warehouse.Domain;
using Warehouse.Infrastructure.EntityFramework;

namespace Warehouse.Infrastructure.Repositories
{
    public class DocumentPZAggregateRepository : BaseAggregateRepository<DocumentPZ>
    {
        public DocumentPZAggregateRepository(WarehouseDbContext context) : base(context)
        {
        }
    }
}