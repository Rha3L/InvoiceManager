using backend.Enums;

namespace backend.Helpers
{
    public class QueryObject
    {
        public DateTime? ApplicationDate { get; set; }

        public ExpenseCategory? Category { get; set; }
    }
}
