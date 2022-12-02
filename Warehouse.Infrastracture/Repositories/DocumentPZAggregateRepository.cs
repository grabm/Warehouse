using Warehouse.Domain;

namespace Warehouse.Infrastructure.Repositories
{
    public class DocumentPZAggregateRepository : BaseRepository<DocumentPZ>
    {
        public DocumentPZAggregateRepository(WarehouseDbContext context) : base(context)
        {
        }
    }
}