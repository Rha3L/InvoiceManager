using Server.Domain.Entities;
using Server.Application.Supplier.Dtos;

namespace Server.Domain.Repositories
{
    public interface ISupplierRepository
    {
        Task<List<Supplier>> GetAllAsync(QueryObject query);
        Task<Supplier?> GetByIdAsync(int id);
        Task<Supplier> CreateAsync(Supplier supplierEntity);
        Task<Supplier?> UpdateAsync(int id, SupplierUpdateDto supplierDto);
        Task<Supplier?> DeleteAsync(int id);
    }
}
