using Euvic.Cqrs.Primitives;
using Warehouse.Application.Abstractions;

namespace Warehouse.Application.Features.Categories.CreateCategory
{
    internal class Handler : ICommandHandler<CreateCategoryCommand, long>
    {
        private IAggregateRepository<Domain.Category> _aggregateRepository;
        public Handler(IAggregateRepository<Domain.Category> aggregateRepository)
        {
            _aggregateRepository = aggregateRepository;

        }

        public async Task<long> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            var category = new Domain.Category(request.Name);

            await _aggregateRepository.CreateAsync(category);

            return category.Id;
        }
    }
}