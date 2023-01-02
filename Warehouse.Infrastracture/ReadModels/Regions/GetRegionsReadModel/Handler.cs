using Microsoft.EntityFrameworkCore;
using Warehouse.Application.Readmodels.Abstractions;
using Warehouse.Application.Readmodels.Regions;
using Warehouse.Domain.ReadModels;
using Warehouse.Infrastructure.EntityFramework.Read;

namespace Warehouse.Infrastructure.ReadModels.Regions.GetRegionsReadModel
{
    internal class Handler : IReadModelQueryHandler<GetRegionsReadModelQuery, IEnumerable<RegionItemReadModel>>
    {
        private readonly WarehouseReadDbContext context;

        public async Task<IEnumerable<RegionItemReadModel>> Handle(GetRegionsReadModelQuery request, CancellationToken cancellationToken)
        {
            return await context.Regions.Select(r => new RegionItemReadModel() { Id = r.Id, Name = r.Name, }).ToListAsync();
        }
    }
}