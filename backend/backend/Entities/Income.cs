using backend.Enums;

namespace backend.Entities
{
    public class Income: BaseEntity
    {
        public IncomeCategory Categories { get; set; }

        public DateTime TransactionDate { get; set; }

        public DateTime DueDate { get; set; }

        public float GST { get; set; }
        
        public float Total {  get; set; }

        public float Net { get; set; }

        public bool Paid { get; set; }

        public string? Notes { get; set; }

        //Relations
        public long CustomerId { get; set; }
        
        public required Customer Customer { get; set; }

        public required User User { get; set; }
    }
}
