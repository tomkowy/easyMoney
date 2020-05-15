using EasyMoney.Modules.FakeManageUsers.Infrastructure;
using Microsoft.Extensions.DependencyInjection;

namespace EasyMoney.Api.StartupConfig
{
    public static class DatabaseConfig
    {
        public static IServiceCollection AddDatabaseConfig(this IServiceCollection services, string connectionString)
        {
            services.AddManageUserContext(connectionString);
            return services;
        }
    }
}
