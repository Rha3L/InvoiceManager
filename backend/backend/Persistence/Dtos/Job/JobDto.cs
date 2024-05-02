using backend.Core.Entities;
using backend.Core.Enums;

namespace backend.Core.Dtos.Job
{
    public class JobDto
    {
        public long ID { get; set; }

        public string Title { get; set; } = String.Empty;

        public JobLevel Level { get; set; }

        public long CompanyId { get; set; }

        public string CompanyName { get; set; } = String.Empty;

        public DateTime CreatedAt { get; set; } = DateTime.Now;

    }
}
