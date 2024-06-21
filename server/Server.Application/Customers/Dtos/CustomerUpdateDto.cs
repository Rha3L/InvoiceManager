using System.ComponentModel.DataAnnotations;

namespace Server.Application.Customers.Dtos
{
    public class CustomerUpdateDto
    {
        [Required]
        public string Name { get; set; } = string.Empty;

        public string ABN { get; set; } = string.Empty;

        public DateTime UpdatedAt { get; set; } = DateTime.Now;

    }
}
