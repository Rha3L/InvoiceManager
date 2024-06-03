using backend.Enums;
using System.ComponentModel.DataAnnotations;

namespace backend.Persistence.Dtos.Company
{
    public class CompanyDto
    {
        public long ID { get; set; }
        [Required]
        public string Name { get; set; } = String.Empty;

        public string ABN { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; } = DateTime.Now;       
    }
}
