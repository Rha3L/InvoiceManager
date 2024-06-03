using backend.Enums;

namespace backend.Entities
{
    public class Company : BaseEntity
    {
        public string Name { get; set; }  = string.Empty;

        public string ABN { get; set; } = string.Empty;

        //Relations
        public ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();
       
    }
}
