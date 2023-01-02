using Euvic.Cqrs.Primitives;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Application.Readmodels.Regions;
using Warehouse.Application.Readmodels.Warehouses;

namespace Warehouse.Application.Features.Regions.Queries.GetRegions
{
    internal class Handler : IQueryHandler<GetRegionsQuery, IEnumerable<RegionItemDto>>
    {
        private readonly IMediator mediator;

        public Handler(IMediator mediator)
        {
            this.mediator = mediator;
        }
        public async Task<IEnumerable<RegionItemDto>> Handle(GetRegionsQuery request, CancellationToken cancellationToken)
        {
            var regions = await mediator.Send(new GetRegionsReadModelQuery()
            {
            }, cancellationToken);

            return regions.Select(x => new RegionItemDto 
            { 
                Id = x.Id, 
                Name = x.Name 
            });
        }
    }
}
