namespace Server.Domain.Entities
{
    public class Customer : BaseEntity
    {
        public string Name { get; set; }  = string.Empty;

        public string? ABN { get; set; }

        //Relations
        public ICollection<Income> Income { get; set; } = new List<Income>();
       
    }
}
