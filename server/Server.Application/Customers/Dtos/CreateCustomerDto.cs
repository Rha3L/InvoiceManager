using System.ComponentModel.DataAnnotations;

namespace Server.Application.Customers.Dtos;

public class CreateCustomerDto
{
    public string Name { get; set; } = string.Empty;

    public string? ABN { get; set; }
}
