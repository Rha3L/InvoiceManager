using Server.Domain.Entities;
using Server.API.Helpers;
using Server.Persistence.Dtos.Invoice;

namespace Server.Domain.Repositories
{
    public interface IExpenseRepository
    {
        Task<List<Income>> GetAllAsync(QueryObject query);
        Task<Income?> GetByIdAsync(int id);
        Task<Income> CreateAsync(Income invoiceEntity);
        Task<Income?> UpdateAsync(int id, IncomeUpdateDto invoiceDto);
        Task<Income?> DeleteAsync(int id);
    }
}
