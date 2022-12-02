using Warehouse.Domain;

namespace Warehouse.Infrastructure.Repositories
{
    public class DocumentKPZAggregateRepository : BaseRepository<DocumentKPZ>
    {
        public DocumentKPZAggregateRepository(WarehouseDbContext context) : base(context)
        {
        }
    }
}