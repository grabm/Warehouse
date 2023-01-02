using Warehouse.Domain.Abstraction;

namespace Warehouse.Domain
{
    public class Category : IAggregateRoot
    {
        public long Id { get; private set; }
        public string Name { get; private set; }

        public Category(string name)
        {
            Name = name;
        }
    }
}
