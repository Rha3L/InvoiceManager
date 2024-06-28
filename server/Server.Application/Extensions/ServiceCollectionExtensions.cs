using Microsoft.Extensions.DependencyInjection;
using Server.Application.Customers;


namespace Server.Application.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddScoped<ICustomerService, CustomerService>();

        }
    }
}
