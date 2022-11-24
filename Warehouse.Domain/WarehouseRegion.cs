using System.Collections.Generic;

namespace Warehouse.Api.Domain
{
    public class WarehouseRegion
    {
        private ICollection<Warehouse> _warehouses;

        public long Id { get; private set; }
        public string Name { get; private set; }

        public IEnumerable<Warehouse> Warehouses => _warehouses;

        public WarehouseRegion(string name)
        {
            Name = name;
        }
    }
}