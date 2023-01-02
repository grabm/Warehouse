using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Warehouse.Api.Controllers.Requests;
using Warehouse.Application.Features.Category.CreateCategory;

namespace Warehouse.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CategoryController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateCatogry([FromBody] CreateCategoryRequest request)
        {
            var categoryId = await _mediator.Send(new CreateCategoryCommand() { Name = request.Name});

            return Ok(categoryId);
        }
    }
}