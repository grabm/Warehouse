using Warehouse.Application.Features.Shared.Models;

namespace Warehouse.Api.Controllers.Requests
{
    public class CreateWarehouseRequest
    {
        public string Name { get; set; }
        public Address Address { get; set; }
    }
}
