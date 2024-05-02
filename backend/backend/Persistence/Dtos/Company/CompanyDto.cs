using backend.Core.Enums;

namespace backend.Core.Dtos.Company
{
    public class CompanyDto
    {
        public long ID { get; set; }

        public string Name { get; set; } = String.Empty;

        public CompanySize Size { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;       
    }
}
