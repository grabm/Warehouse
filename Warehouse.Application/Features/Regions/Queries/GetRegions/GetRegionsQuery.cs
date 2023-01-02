using Euvic.Cqrs.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Application.Features.Warehouses.Queries.GetWarehouse;

namespace Warehouse.Application.Features.Regions.Queries.GetRegions
{
    public class GetRegionsQuery : IQuery<IEnumerable<RegionItemDto>>
    {
    }

    public class RegionItemDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }
}