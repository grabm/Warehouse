using MediatR;

namespace Warehouse.Application.Readmodels.Abstractions
{
    public interface IReadModelQueryHandler<in TQuery, TResponse> : IRequestHandler<TQuery, TResponse>
        where TQuery : IReadModelQuery<TResponse>
    {
    }
}
