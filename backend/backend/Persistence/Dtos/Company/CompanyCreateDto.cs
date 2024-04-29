using System.ComponentModel.DataAnnotations;
using backend.Core.Enums;

namespace backend.Core.Dtos.Company
{
    public class CompanyCreateDto
    {
        [Required]
        public string Name { get; set; } = string.Empty;

        public CompanySize Size { get; set; }
    }
}
