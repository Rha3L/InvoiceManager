using System.ComponentModel.DataAnnotations;

namespace backend.Persistence.Dtos.Supplier
{
    public class SupplierDto
    {
        public long ID { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;

        public string ABN { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
