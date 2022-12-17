using CQRS.Domain.Commands.Requests;
using CQRS.Domain.Commands.Responses;

namespace CQRS.Domain.Commands.Handlers;

public interface ICreateCustomerHandler
{
    CreateCustomerResponse Handle(CreateCustomerRequest request);
}