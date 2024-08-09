using Architecht.API.Filters;
using Architecht.Application.Queries;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Architecht.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrderController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [ResponseHeaderFilter("email", "cagatay@mail.com")]
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var query = new GetAllOrdersQuery();
            var result = await _mediator.Send(query);

            return Ok(result);
        }

    }
}
