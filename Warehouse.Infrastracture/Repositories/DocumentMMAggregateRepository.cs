using Warehouse.Domain;

namespace Warehouse.Infrastructure.Repositories
{
    public class DocumentMMAggregateRepository : BaseRepository<DocumentMM>
    {
        public DocumentMMAggregateRepository(WarehouseDbContext context) : base(context)
        {
        }
    }
}