using System;

namespace Warehouse.Api.Domain
{
    public class DocumentItem
    {
        public long Id { get; private set; }
        public decimal Quantity { get; private set; }
        public decimal Price { get; private set; }
        public long ProductId { get; private set; }  
        public long MeasurementUnitId { get; private set; }

        public DocumentItem(decimal quantity, decimal price, long productId, long measurementUnitId)
        {
            Quantity = quantity;
            Price = price;
            ProductId = productId;
            MeasurementUnitId = measurementUnitId;
        }
    }
}