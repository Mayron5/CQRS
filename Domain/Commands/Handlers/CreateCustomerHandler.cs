using CQRS.Domain.Commands.Requests;
using CQRS.Domain.Commands.Responses;
using MediatR;

namespace CQRS.Domain.Commands.Handlers;

public class CreateCustomerHandler : IRequestHandler<CreateCustomerRequest, CreateCustomerResponse>
{
    public Task<CreateCustomerResponse> Handle(CreateCustomerRequest request, CancellationToken cancellationToken)
    {
        var result = new CreateCustomerResponse
        {
            Id = Guid.NewGuid(),
            Name = "Mayron Alves",
            Email = "mayron@alves.com",
            Date = DateTime.Now
        };
        return Task.FromResult(result);
    }
}