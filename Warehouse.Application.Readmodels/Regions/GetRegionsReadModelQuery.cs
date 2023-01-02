using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Application.Readmodels.Abstractions;
using Warehouse.Domain.ReadModels;

namespace Warehouse.Application.Readmodels.Regions
{
    public class GetRegionsReadModelQuery : IReadModelQuery<IEnumerable<RegionItemReadModel>>
    {
    }
}