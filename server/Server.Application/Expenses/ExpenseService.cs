using AutoMapper;
using Microsoft.Extensions.Logging;
using Server.Application.Expenses;
using Server.Application.Expenses.Dtos;
using Server.Domain.Repositories;

namespace Server.Application.Expenses;

internal class ExpenseService(IExpenseRepository expenseRepository, ILogger<ExpenseService> logger, IMapper mapper) : IExpenseService
{
    public async Task<IEnumerable<ExpenseDto>> GetAllExpenses()
    {
        logger.LogInformation("Getting all expenses");
        var expenses = await expenseRepository.GetAllAsync();
        var convertedExpenses = mapper.Map<IEnumerable<ExpenseDto>>(expenses);
        return convertedExpenses;
    }

    public async Task<ExpenseDto?> GetExpenseById(int id)
    {
        logger.LogInformation($"Getting expense {id}");
        var expense = await expenseRepository.GetByIdAsync(id);
        var convertedExpense = mapper.Map<ExpenseDto>(expense);
        return convertedExpense;
    }
}
