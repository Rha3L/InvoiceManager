using Server.Application.Expenses;
using System.ComponentModel.DataAnnotations;

namespace Server.Application.Suppliers.Dtos;

public class SupplierDto
{
    public int ID { get; set; }
    [Required]
    public string Name { get; set; } = string.Empty;

    public string ABN { get; set; } = string.Empty;

    public ICollection<ExpenseDto> Expenses { get; set; } = [];
}

