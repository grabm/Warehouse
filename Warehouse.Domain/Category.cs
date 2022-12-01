using Warehouse.Domain.Abstraction;

namespace Warehouse.Domain
{
    public class Category : IAggregateRoot
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }
}
