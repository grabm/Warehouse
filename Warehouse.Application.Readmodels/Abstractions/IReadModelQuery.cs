namespace Warehouse.Application.Readmodels.Abstractions
{
    public interface IReadModelQuery<out TResult> : MediatR.IRequest<TResult> { }
}
