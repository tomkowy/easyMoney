using EasyMoney.Modules.FakeManageUsers.Domain.Users;
using EasyMoney.Modules.FakeManageUsers.Infrastructure.Context;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace EasyMoney.Modules.FakeManageUsers.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddManageUserContext(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<ManageUsersContext>(options => options.UseSqlServer(connectionString));


            services.AddIdentity<User, ApplicationRole>()
                .AddEntityFrameworkStores<ManageUsersContext>()
                .AddDefaultTokenProviders();
            return services;
        }
    }
}
