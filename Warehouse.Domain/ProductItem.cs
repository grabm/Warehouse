using System;

namespace Warehouse.Domain
{
    public class ProductItem
    {
        public long Id { get; private set; }
        public decimal Quantity { get; private set; }
        public decimal Price { get; private set; }
        public long ProductId { get; private set; }
        public long DocumentItemId { get; private set; }
        public DateTime CreateDate { get; private set; }

        public ProductItem(DocumentItem documentItem)
        {
            Quantity = documentItem.Quantity;
            Price = documentItem.Price;
        }
    }
}
