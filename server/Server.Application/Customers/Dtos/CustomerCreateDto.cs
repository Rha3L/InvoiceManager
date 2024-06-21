using System.ComponentModel.DataAnnotations;

namespace Server.Application.Customers.Dtos
{
    public class CustomerCreateDto
    {
        [Required]
        public string Name { get; set; } = string.Empty;

        public string ABN { get; set; } = string.Empty;
    }
}
