using Warehouse.Domain.Abstraction;

namespace Warehouse.Domain
{
    public class Address : ValueObject
    {
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
    }
}
