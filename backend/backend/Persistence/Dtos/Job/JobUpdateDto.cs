using backend.Enums;

namespace backend.Persistence.Dtos.Job
{
    public class JobUpdateDto
    {
        public string Title { get; set; } = String.Empty;

        public JobLevel Level { get; set; }

        public long CompanyId { get; set; }
    }
}
