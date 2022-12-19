using Euvic.Cqrs.Primitives;
using Warehouse.Application.Abstractions;

namespace Warehouse.Application.Features.Warehouse.Commands.CreateWarehouse
{
    internal class Handler : ICommandHandler<CreateWarehouseCommand, long>
    {
        private IAggregateRepository<Domain.Region> _aggregateRepository;

        public Handler(IAggregateRepository<Domain.Region> aggregateRepository)
        {
            _aggregateRepository = aggregateRepository;
        }

        public async Task<long> Handle(CreateWarehouseCommand request, CancellationToken cancellationToken)
        {
            var region = await _aggregateRepository.GetAsync(request.RegionId, x=>x.Warehouses);
            var warehouse = region.AddWarehouse(request.Name,
                new Domain.Address
                {
                    City = request.Address.City,
                    Country = request.Address.Country,
                    Street = request.Address.Street
                });

            await _aggregateRepository.SaveChangesAsync();

            return warehouse.Id;
        }
    }
}