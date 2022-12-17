using CQRS.Domain.Commands.Requests;
using CQRS.Domain.Commands.Responses;

namespace CQRS.Domain.Commands.Handlers;

public class CreateCustomerHandler : ICreateCustomerHandler
{
    public CreateCustomerResponse Handle(CreateCustomerRequest request)
    {
        // Verifica se o cliente já está cadastrado.
        // Valida os dados
        // Insere o cliente no banco
        // Envia e-mail de boas vindas

        return new CreateCustomerResponse
        {
            Id = Guid.NewGuid(),
            Name = "Mayron Alves",
            Email = "mayron@alves.com",
            Date = DateTime.Now
        };
    }
}