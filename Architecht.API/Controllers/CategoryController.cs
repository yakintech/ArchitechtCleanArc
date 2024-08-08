using Architecht.Application.Commands;
using Architecht.Application.DTO;
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

        [HttpGet("{page}/{pagesize}")]
        public async Task<IActionResult> Get(int page, int pagesize)
        {
            var query = new GetCategoriesWithPaginationQuery();
            query.Page = page;
            query.PageSize = pagesize;

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


        [HttpPost]
        public async Task<IActionResult> Post(CreateCategoryDto model)
        {

            var createCategoryCommand = new CreateCategoryCommand
            {
                Name = model.Name
            };

            var result = await _mediator.Send(createCategoryCommand);
            return Ok(result);

        }


        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, UpdateCategoryDto model)
        {
            var updateCategoryCommand = new UpdateCategoryCommand
            {
                Id = id,
                Name = model.Name
            };

            var result = await _mediator.Send(updateCategoryCommand);
            return Ok(result);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var deleteCategoryCommand = new DeleteCategoryCommand
            {
                Id = id
            };

            var result = await _mediator.Send(deleteCategoryCommand);
            return Ok(result);
        }
    }
}
