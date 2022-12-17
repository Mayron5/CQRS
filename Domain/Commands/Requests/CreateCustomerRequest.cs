using MediatR;
using CQRS.Domain.Commands.Responses;

namespace CQRS.Domain.Commands.Requests;

public class CreateCustomerRequest : IRequest<CreateCustomerResponse>
{

    public CreateCustomerRequest(string Name, string Email)
    {
        this.Name = Name;
        this.Email = Email;
    }

    public string Name { get; set; }
    public string Email { get; set; }
}