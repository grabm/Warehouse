using Warehouse.Domain;

namespace Warehouse.Infrastructure.Repositories
{
    public class DocumentWZAggregateRepository : BaseRepository<DocumentWZ>
    {
        public DocumentWZAggregateRepository(WarehouseDbContext context) : base(context)
        {
        }
    }
}