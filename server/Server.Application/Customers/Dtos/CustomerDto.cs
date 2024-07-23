using Server.Application.Income.Dtos;

namespace Server.Application.Customers.Dtos;

public class CustomerDto
{
    public int ID { get; set; }
  
    public string Name { get; set; } = string.Empty;

    public string? ABN { get; set; }

    public ICollection<IncomeDto> Income { get; set; } = [];
}
