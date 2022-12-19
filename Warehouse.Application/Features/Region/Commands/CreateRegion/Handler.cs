using Euvic.Cqrs.Primitives;
using Warehouse.Application.Abstractions;

namespace Warehouse.Application.Features.Region.Commands.CreateRegion
{
    internal class Handler : ICommandHandler<CreateRegionCommand, long>
    {
        private IAggregateRepository<Domain.Region> _aggregateRepository;

        public Handler(IAggregateRepository<Domain.Region> aggregateRepository)
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
