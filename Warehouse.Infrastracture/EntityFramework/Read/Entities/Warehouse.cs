using Warehouse.Domain;

namespace Warehouse.Infrastructure.EntityFramework.Read.Entities
{
    public class Warehouse
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long RegionId { get; set; }

        public Region Region { get; set; }
        public Address Address { get; set; }
    }
}