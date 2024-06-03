using backend.Entities;
using backend.Enums;
using System.ComponentModel.DataAnnotations;

namespace backend.Persistence.Dtos.Invoice
{
    public class InvoiceDto
    {
        public long ID { get; set; }
        public InvoiceCategory Categories { get; set; }

        public DateTime PurchaseDate { get; set; }

        public bool AnyGST { get; set; }

        public float GST { get; set; }

        public float Total { get; set; }

        public float Net { get; set; }

        [MaxLength(100, ErrorMessage = "Notes cannot be over 100 characters")]
        public string Notes { get; set; } = string.Empty;

        public long CompanyId { get; set; }

        public string CompanyName { get; set; } = String.Empty;

        public DateTime CreatedAt { get; set; } = DateTime.Now;

    }
}
