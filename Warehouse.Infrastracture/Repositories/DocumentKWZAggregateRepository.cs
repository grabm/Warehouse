using Warehouse.Domain;

namespace Warehouse.Infrastructure.Repositories
{
    public class DocumentKWZAggregateRepository : BaseRepository<DocumentKWZ>
    {
        public DocumentKWZAggregateRepository(WarehouseDbContext context) : base(context)
        {
        }
    }
}