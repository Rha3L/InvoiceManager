using backend.Enums;

namespace backend.Persistence.Dtos.Job
{
    public class JobCreateDto
    {
        public string Title { get; set; } = String.Empty;

        public JobLevel Level { get; set; }

        public long CompanyId { get; set; }
    }
}
