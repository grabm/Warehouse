using Euvic.Cqrs.Primitives;
using MediatR;
using Warehouse.Application.Features.Warehouses.ReadModelQuery;
using Warehouse.Application.Readmodels.Warehouses;

namespace Warehouse.Application.Features.Warehouses.Queries.GetWarehouse
{
    public class Handler : IQueryHandler<GetWarehouseQuery, WarehouseDto>
    {
        private readonly IMediator mediator;

        public Handler(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public async Task<WarehouseDto> Handle(GetWarehouseQuery request, CancellationToken cancellationToken)
        {
            var warehouse = await mediator.Send(new GetWarehouseReadModelQuery()
            {
                Id = request.WarehouseId
            }, cancellationToken);

            return new WarehouseDto()
            {
                Id = warehouse.Id,
                Name = warehouse.Name,
                RegionId = warehouse.RegionId,
                Address = new Shared.Models.Address()
                {
                    City = warehouse.Address.City,
                    Country = warehouse.Address.Country,
                    Street = warehouse.Address.Street,
                }
            };
        }
    }
}