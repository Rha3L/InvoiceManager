using Server.Domain.Entities;
using Server.API.Helpers;
using Server.Application.Expense.Dtos;

namespace Server.Domain.Repositories
{
    public interface IExpenseRepository
    {
        Task<List<Expense>> GetAllAsync();
        Task<Expense?> GetByIdAsync(int id);
        Task<Expense> CreateAsync(Income expenseEntity);
        Task<Expense?> UpdateAsync(int id, ExpenseUpdateDto expenseDto);
        Task<Expense?> DeleteAsync(int id);
    }
}
