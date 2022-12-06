using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Warehouse.Api.Controllers.Requests;
using Warehouse.Application.Abstractions;
using Warehouse.Domain;

namespace Warehouse.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IAggregateRepository<Category> _aggregateRepository;

        public CategoryController(IAggregateRepository<Category> aggregateRepository)
        {
            _aggregateRepository = aggregateRepository;
        }

        [HttpPost]
        public async Task<IActionResult> CreateCatogry([FromBody] CreateCategoryRequest request)
        {
            await _aggregateRepository.CreateAsync(new Category
            {
                Name = request.Name
            });

            return Ok();
        }
    }
}
