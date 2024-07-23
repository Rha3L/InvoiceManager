using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Server.Domain.Repositories;
using Server.Infrastructure.Repositories;

namespace Server.Infrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddInfastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<ISupplierRepository, SupplierRepository>();
            services.AddScoped<IIncomeRepository, IncomeRepository>();
            services.AddScoped<IExpenseRepository, ExpenseRepository>();

        }
    }
}
