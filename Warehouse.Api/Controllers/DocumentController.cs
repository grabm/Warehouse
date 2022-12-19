using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Warehouse.Api.Controllers.Requests;
using Warehouse.Application.Abstractions;
using Warehouse.Domain;

namespace Warehouse.Api.Controllers
{
    [Route("api/documents")]
    [ApiController]
    public class DocumentController : ControllerBase
    {
        private readonly IAggregateRepository<DocumentPZ> _documentPZRepository;
        private readonly IAggregateRepository<DocumentKPZ> _documentKPZRepository;

        public DocumentController(IAggregateRepository<DocumentPZ> documentRepository,
            IAggregateRepository<DocumentKPZ> documentKPZRepository)
        {
            _documentPZRepository = documentRepository;
            _documentKPZRepository = documentKPZRepository;
        }

        [HttpPost("pz")]
        public async Task<IActionResult> CreateCatogry([FromBody] CreateCategoryRequest request)
        {
            await _documentPZRepository.CreateAsync(new DocumentPZ("abc123",
                new List<DocumentItem> { new DocumentItem(1, 2, 1) }));

            return Ok();
        }
        [HttpPost("kpz")]
        public async Task<IActionResult> CreateDocumentKPZ()
        {
            await _documentKPZRepository.CreateAsync(new DocumentKPZ("abc123Korekta",1,
                new List<DocumentItem> { new DocumentItem(2, 2, 1) }));

            return Ok();
        }
    }
}