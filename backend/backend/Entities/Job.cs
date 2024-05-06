using Microsoft.Extensions.Logging;
using backend.Enums;
using static backend.Entities.Company;

namespace backend.Entities
{
    public class Job: BaseEntity
    {
        public string Title { get; set; } = string.Empty;

        public JobLevel Level { get; set; }

        //Relations
        public long CompanyId { get; set; }

        public Company? Company { get; set; }

        public ICollection<User>? Users { get; set; }
    }
}
