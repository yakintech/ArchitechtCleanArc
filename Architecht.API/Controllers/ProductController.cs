using Architecht.Application.Commands;
using Architecht.Application.DTO;
using Architecht.Application.Queries.ECommerce.Product;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Architecht.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var getAllProductsQuery = new GetAllProductsQuery();
            var result = await _mediator.Send(getAllProductsQuery);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var getProductByIdQuery = new GetProductByIdQuery();
            getProductByIdQuery.Id = id;
            var result = await _mediator.Send(getProductByIdQuery);
            return Ok(result);
        }


        [HttpPost]
        public async Task<IActionResult> Post(CreateProductDto model)
        {
            var createProductCommand = new CreateProductCommand();
            
            createProductCommand.Name = model.Name;
            createProductCommand.Description = model.Description;
            createProductCommand.Price = model.Price;
            createProductCommand.Stock = model.Stock;
            createProductCommand.CategoryId = model.CategoryId;

           var result = await _mediator.Send(createProductCommand);

            return Ok(result);
        }
    }
}
