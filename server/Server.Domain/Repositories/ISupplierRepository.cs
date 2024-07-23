using Server.Domain.Entities;

namespace Server.Domain.Repositories
{
    public interface ISupplierRepository
    {
        Task<IEnumerable<Supplier>> GetAllAsync();
        Task<Supplier?> GetByIdAsync(int id);
        Task<int> CreateSupplier(Supplier supplierEntity);
        Task<Supplier?> UpdateAsync(int id);
        Task<Supplier?> DeleteAsync(int id);
    }
}
