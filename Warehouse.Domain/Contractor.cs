using Warehouse.Domain.Abstraction;

namespace Warehouse.Domain
{
    public class Contractor : IAggregateRoot
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }
    }
}