using backend.Domain.Entities;
using backend.Helpers;
using backend.Persistence.Dtos.Invoice;

namespace backend.Interfaces
{
    public interface IInvoiceRepository
    {
        Task<List<Income>> GetAllAsync(QueryObject query);
        Task<Income?> GetByIdAsync(int id);
        Task<Income> CreateAsync(Income invoiceEntity);
        Task<Income?> UpdateAsync(int id, IncomeUpdateDto invoiceDto);
        Task<Income?> DeleteAsync(int id);
    }
}
