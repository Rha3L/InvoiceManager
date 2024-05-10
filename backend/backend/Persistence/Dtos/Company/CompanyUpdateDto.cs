using backend.Enums;
using System.ComponentModel.DataAnnotations;

namespace backend.Persistence.Dtos.Company
{
    public class CompanyUpdateDto
    {
        [Required]
        public string Name { get; set; } = string.Empty;

        public CompanySize Size { get; set; }
    }
}
