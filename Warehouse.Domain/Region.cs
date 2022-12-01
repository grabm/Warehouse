using System.Collections.Generic;
using Warehouse.Domain.Abstraction;

namespace Warehouse.Domain
{
    public class Region : IAggregateRoot
    {
        private ICollection<Warehouse> _warehouses;

        public long Id { get; private set; }
        public string Name { get; private set; }

        public IEnumerable<Warehouse> Warehouses => _warehouses;

        public Region(string name)
        {
            Name = name;
        }
    }
}