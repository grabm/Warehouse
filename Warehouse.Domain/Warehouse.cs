namespace Warehouse.Domain
{
    public class Warehouse
    {
        public long Id { get; private set; }
        public string Name { get; private set; }
        public long WarehouseRegionId { get; private set; }

        public Address Address { get; private set; }

        public Warehouse(string name, long warehouseRegionId, Address address)
        {
            Name = name;
            WarehouseRegionId = warehouseRegionId;
            Address = address;
        }

        public void UpdateRegion(long warehoursRegionId)
        {
            WarehouseRegionId = warehoursRegionId;
        }
    }
}