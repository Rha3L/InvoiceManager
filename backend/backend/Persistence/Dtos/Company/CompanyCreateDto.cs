using backend.Enums;

namespace backend.Persistence.Dtos.Company
{
    public class CompanyCreateDto
    { 
        public string Name { get; set; } = string.Empty;

        public CompanySize Size { get; set; }
    }
}
