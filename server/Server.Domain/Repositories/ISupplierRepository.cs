using Server.Domain.Entities;

namespace Server.Domain.Repositories
{
    public interface ISupplierRepository
    {
        Task<List<Income>> GetAllAsync(QueryObject query);
        Task<Income?> GetByIdAsync(int id);
        Task<Income> CreateAsync(Income invoiceEntity);
        Task<Income?> UpdateAsync(int id, IncomeUpdateDto invoiceDto);
        Task<Income?> DeleteAsync(int id);
    }
}
