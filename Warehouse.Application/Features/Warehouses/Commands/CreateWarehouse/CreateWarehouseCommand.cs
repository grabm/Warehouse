using Euvic.Cqrs.Primitives;
using Warehouse.Application.Features.Shared.Models;

namespace Warehouse.Application.Features.Warehouses.Commands.CreateWarehouse
{
    public class CreateWarehouseCommand : ICommand<long>
    {
        public string Name { get; set; }
        public long RegionId { get; set; }
        public Address Address { get; set; }
    }
}