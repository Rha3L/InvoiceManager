using backend.Core.Enums;
using Microsoft.Extensions.Logging;
using static backend.Core.Entities.Company;

namespace backend.Core.Entities
{
    public class Job: BaseEntity
    {
        public string Title { get; set; } = string.Empty;

        public JobLevel Level { get; set; }

        //Relations
        public long CompanyId { get; set; }

        public Company? Company { get; set; }

        public ICollection<Candidate>? Candidates { get; set; }
    }
}
