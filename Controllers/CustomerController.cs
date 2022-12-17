using CQRS.Domain.Commands.Handlers;
using CQRS.Domain.Commands.Requests;
using CQRS.Domain.Commands.Responses;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRS.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CustomerController : ControllerBase
{
    [HttpPost]
    public Task<CreateCustomerResponse> Create(
        [FromServices] IMediator mediator,
        [FromBody] CreateCustomerRequest command
    )
    {
        return mediator.Send(command);
    }
}