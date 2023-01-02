using Euvic.Cqrs.Primitives;
using Warehouse.Application.Features.Shared.Models;

namespace Warehouse.Application.Features.Warehouses.Queries.GetWarehouse
{
    public class GetWarehouseQuery : IQuery<WarehouseDto>
    {
        public long WarehouseId { get; set; }
    }

    public class WarehouseDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long RegionId { get; set; }
        public Address Address { get; set; }
    }
}