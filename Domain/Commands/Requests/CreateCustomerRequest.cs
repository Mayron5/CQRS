namespace CQRS.Domain.Commands.Requests;

public class CreateCustomerRequest
{

    public CreateCustomerRequest(string Name, string Email)
    {
        this.Name = Name;
        this.Email = Email;
    }

    public string Name { get; set; }
    public string Email { get; set; }
}