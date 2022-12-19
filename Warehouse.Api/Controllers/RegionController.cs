using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Warehouse.Api.Controllers.Requests;
using Warehouse.Application.Abstractions;
using Warehouse.Application.Features.Region.Commands.CreateRegion;
using Warehouse.Application.Features.Warehouse.Commands.CreateWarehouse;
using Warehouse.Domain;

namespace Warehouse.Api.Controllers
{
    [Route("api/regions")]
    [ApiController]
    public class RegionController : ControllerBase
    {
        private IMediator _mediator;

        public RegionController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateCatogry([FromBody] CreateRegionRequest request)
        {
            //await _aggregateRepository.CreateAsync(new Category
            //{
            //    Name = request.Name
            //});

            var regionId = await _mediator.Send(new CreateRegionCommand() { Name = request.Name });

            return Ok(regionId);
        }

        [HttpPost("{id}/warehouses")]
        public async Task<IActionResult> AddWarehouse([FromRoute] long id, [FromBody] CreateWarehouseRequest request)
        {
            var warehouseId = await _mediator.Send(new CreateWarehouseCommand() { Address = request.Address, Name = request.Name, RegionId = id });

            return Ok(warehouseId);
        }
    }
}
