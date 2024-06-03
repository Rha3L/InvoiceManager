using Microsoft.Extensions.Logging;
using backend.Enums;
using static backend.Entities.Company;
using Microsoft.Identity.Client;

namespace backend.Entities
{
    public class Invoice: BaseEntity
    {
        public string Title { get; set; } = string.Empty;

        public InvoiceCategory Categories { get; set; }

        public DateTime PurchaseDate { get; set; }

        public bool AnyGST { get; set; }

        public float GST { get; set; }
        
        public float Total {  get; set; }

        public float Net { get; set; }

        public string Notes { get; set; } = string.Empty;

        //Relations
        public long CompanyId { get; set; }
        
        public required Company Company { get; set; }

        public required User User { get; set; }
    }
}
