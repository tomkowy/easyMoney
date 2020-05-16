using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace EasyMoney.Modules.FakeManageUsers.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddFakeManageUsersApplication(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
