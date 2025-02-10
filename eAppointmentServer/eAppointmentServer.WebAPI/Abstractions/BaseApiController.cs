using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eAppointmentServer.WebAPI.Abstractions
{
    [Route("api/[controller]/[action]")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    [ApiController]
    public abstract class BaseApiController: ControllerBase
    {
        public readonly IMediator _mediator;

        protected BaseApiController(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}
