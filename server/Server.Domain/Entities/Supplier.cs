namespace Server.Domain.Entities
{
    public class Supplier: BaseEntity
    {
        public string Name { get; set; } = string.Empty;

        public string ABN { get; set; } = string.Empty;

        //Relations
        public ICollection<Expense> Expenses { get; set; } = new List<Expense>();
    }
}
