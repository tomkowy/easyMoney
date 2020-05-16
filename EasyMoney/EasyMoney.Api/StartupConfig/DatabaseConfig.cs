using EasyMoney.Modules.FakeManageUsers.Infrastructure;
using EasyMoney.Modules.FakeNotifications.Infrastructure;
using Microsoft.Extensions.DependencyInjection;

namespace EasyMoney.Api.StartupConfig
{
    public static class DatabaseConfig
    {
        public static IServiceCollection AddDatabaseConfig(this IServiceCollection services, string connectionString)
        {
            services.AddManageUserContext(connectionString);
            services.AddNotificationsContext(connectionString);
            return services;
        }
    }
}
