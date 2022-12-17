using CQRS.Domain.Commands.Handlers;
using CQRS.Domain.Commands.Requests;
using CQRS.Domain.Commands.Responses;
using Microsoft.AspNetCore.Mvc;

namespace CQRS.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CustomerController : ControllerBase
{
    [HttpPost]
    public CreateCustomerResponse Create(
        [FromServices] ICreateCustomerHandler handler,
        [FromBody] CreateCustomerRequest command
    )
    {
        return handler.Handle(command);
    }
}