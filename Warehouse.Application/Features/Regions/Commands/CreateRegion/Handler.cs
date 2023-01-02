using Euvic.Cqrs.Primitives;
using Warehouse.Application.Abstractions;

namespace Warehouse.Application.Features.Regions.Commands.CreateRegion
{
    internal class Handler : ICommandHandler<CreateRegionCommand, long>
    {
        private IAggregateRepository<Warehouse.Domain.ReadModels.Region> _aggregateRepository;

        public Handler(IAggregateRepository<Warehouse.Domain.ReadModels.Region> aggregateRepository)
        {
            _aggregateRepository = aggregateRepository;
        }

        public async Task<long> Handle(CreateRegionCommand request, CancellationToken cancellationToken)
        {
            var region = new Domain.Region(request.Name);

            await _aggregateRepository.CreateAsync(region);

            return region.Id;
        }
    }
}
