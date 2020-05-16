using EasyMoney.Modules.FakeNotifications.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace EasyMoney.Modules.FakeNotifications.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddNotificationsContext(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<NotificationsContext>(options => options.UseSqlServer(connectionString));
            return services;
        }
    }
}
