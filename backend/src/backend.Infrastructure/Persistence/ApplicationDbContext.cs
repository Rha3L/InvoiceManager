using backend.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace backend.Infrastructure.Persistence
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        internal DbSet<Customer> Customers { get; set; }

        internal DbSet<Income> Income { get; set; }

        internal DbSet<Supplier> Suppliers { get; set; }
        internal DbSet<Expense> Expenses { get; set; }
        internal DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Income>()
                .HasOne(income => income.Customer)
                .WithMany(customer => customer.Income)
                .HasForeignKey(income => income.CustomerId);

            modelBuilder.Entity<Income>()
                .Property(income => income.Categories)
                .HasConversion<string>();

            modelBuilder.Entity<Expense>()
                .HasOne(expense => expense.Supplier)
                .WithMany(supplier => supplier.Expenses)
                .HasForeignKey(expense => expense.SupplierId);

            modelBuilder.Entity<Expense>()
                .Property(expense => expense.Categories)
                .HasConversion<string>();
        }
    }
}
