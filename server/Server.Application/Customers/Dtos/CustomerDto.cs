using System.ComponentModel.DataAnnotations;

namespace Server.Application.Customers.Dtos
{
    public class CustomerDto
    {
        public long ID { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;

        public string ABN { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; } = DateTime.Now;       
    }
}
