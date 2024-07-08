
namespace Server.Application.Expenses
{
    internal interface IExpenseService
    {
        Task<IEnumerable<ExpenseDto>> GetAllExpenses();
        Task<ExpenseDto?> GetExpenseById(int id);
    }
}