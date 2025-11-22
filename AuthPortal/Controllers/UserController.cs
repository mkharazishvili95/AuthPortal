using AuthPortal.Application.Features.User.Queries.Get;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AuthPortal.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        readonly IMediator _mediator;
        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<GetUserResponse> Get([FromQuery]GetUserQuery request) => await _mediator.Send(request);
    }
}
