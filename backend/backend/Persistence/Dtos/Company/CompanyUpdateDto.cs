using backend.Enums;
using System.ComponentModel.DataAnnotations;

namespace backend.Persistence.Dtos.Company
{
    public class CompanyUpdateDto
    {
        [Required]
        public string Name { get; set; } = string.Empty;

        public string ABN { get; set; } = string.Empty;
    }
}
