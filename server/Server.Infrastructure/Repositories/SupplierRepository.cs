using Microsoft.EntityFrameworkCore;
using Server.Domain.Entities;
using Server.Domain.Repositories;
using Server.Infrastructure.Persistence;

namespace Server.Infrastructure.Repositories
{
    public class SupplierRepository: ISupplierRepository
    {
        private readonly ApplicationDbContext _context;
        public SupplierRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> CreateSupplier(Supplier supplierEntity)
        {
            await _context.Suppliers.AddAsync(supplierEntity);
            await _context.SaveChangesAsync();
            return supplierEntity.ID;
        }
        public async Task<IEnumerable<Supplier>> GetAllAsync()
        {
            return await _context.Suppliers.ToListAsync();
        }

        public async Task<Supplier?> GetByIdAsync(int id)
        {
            return await _context.Suppliers.FirstOrDefaultAsync(i => i.ID == id);
        }
    }
}
