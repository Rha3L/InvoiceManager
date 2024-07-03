using Server.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace Server.Application.Suppliers.Dtos;

public class SupplierDto
{
    public long ID { get; set; }
    [Required]
    public string Name { get; set; } = string.Empty;

    public string ABN { get; set; } = string.Empty;

    public ICollection<Expense> Expenses { get; set; } = [];
}

