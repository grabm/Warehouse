using Euvic.Cqrs.Primitives;

namespace Warehouse.Application.Features.Categories.CreateCategory
{
    public class CreateCategoryCommand : ICommand<long>
    {
        public string Name { get; set; }
    }
}