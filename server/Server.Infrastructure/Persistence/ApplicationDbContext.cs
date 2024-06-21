using Server.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Server.Infrastructure.Persistence
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Income> Income { get; set; }

        public DbSet<Supplier> Suppliers { get; set; }

        public DbSet<Expense> Expenses { get; set; }

        public DbSet<User> Users { get; set; }

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
