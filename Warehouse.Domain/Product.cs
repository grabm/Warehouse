using System.Collections.Generic;

namespace Warehouse.Api.Domain
{
    public class Product
    {
        private ICollection<ProductItem> _items;

        public long Id { get; private set; }
        public string Name { get; private set; }
        public long WarehouseId { get; private set; }
        public long MeasurementUnitId { get; private set; }

        public ICollection<ProductItem> Items => _items;

        public Product(string name, long warehouseId)
        {
            Name = name;
            WarehouseId = warehouseId;
        }

        public void AddItem(DocumentItem documentItem)
        {
            _items.Add(new ProductItem(documentItem));
        }
    }
}