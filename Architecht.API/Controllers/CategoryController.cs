using Architecht.Application.Queries;
using Architecht.Infrastructure.UnitOfWork;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Architecht.API.Controllers
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
      

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var query = new GetAllCategoriesQuery();
            var result = await _mediator.Send(query);


            return Ok(result);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var query = new GetCategoryByIdQuery();
            query.Id = id;

            var result = await _mediator.Send(query);

            return Ok(result);
        }
    }
}
