using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Application.Readmodels.Abstractions;
using Warehouse.Application.Readmodels.Warehouses;
using Warehouse.Domain.ReadModels;
using Warehouse.Infrastructure.EntityFramework.Read;

namespace Warehouse.Infrastructure.ReadModels.Warehouses.GetWarehouseReadModel
{
    internal class Handler : IReadModelQueryHandler<GetWarehouseReadModelQuery, WarehouseReadModel>
    {
        private readonly WarehouseReadDbContext context;

        public async Task<WarehouseReadModel> Handle(GetWarehouseReadModelQuery request, CancellationToken cancellationToken)
        {
            return await context.Warehouse.Where(x => x.Id == request.Id).Select(x => new WarehouseReadModel()
            {
                Id = x.Id,
                Name = x.Name
            }).FirstOrDefaultAsync();
        }
    }
}