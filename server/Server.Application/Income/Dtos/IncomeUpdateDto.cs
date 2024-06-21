using backend.Enums;
using System.ComponentModel.DataAnnotations;

namespace backend.Persistence.Dtos.Income
{
    public class IncomeUpdateDto
    {
        public IncomeCategory Categories { get; set; }

        public DateTime TransactionDate { get; set; }

        public DateTime DueDate { get; set; }

        public float GST { get; set; }

        public float Total { get; set; }

        public float Net { get; set; }

        public bool Paid { get; set; }

        [MaxLength(100, ErrorMessage = "Notes cannot be over 100 characters")]
        public string? Notes { get; set; }

        public long CompanyId { get; set; }
    }
}
