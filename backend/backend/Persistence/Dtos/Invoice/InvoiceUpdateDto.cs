using backend.Enums;
using System.ComponentModel.DataAnnotations;

namespace backend.Persistence.Dtos.Invoice
{
    public class InvoiceUpdateDto
    {
        public InvoiceCategory Categories { get; set; }

        public DateTime PurchaseDate { get; set; }

        public bool AnyGST { get; set; }

        public float GST { get; set; }

        public float Total { get; set; }

        public float Net { get; set; }

        [MaxLength(100, ErrorMessage = "Notes cannot be over 100 characters")]
        public string Notes { get; set; } = string.Empty;

        public long CompanyId { get; set; }
    }
}
