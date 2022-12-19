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
            _warehouses = new List<Warehouse>();
        } 

        public Warehouse AddWarehouse(string name, Address address)
        {
            if (_warehouses.Any(x => x.Name == name || x.Address == address))
            {
                throw new Exception("Już istnieje magazyn o tej nazwie lub adresie");
            }

            var warehouse = new Warehouse(name, Id, address);
            _warehouses.Add(warehouse);

            return warehouse;
        }
    }
}