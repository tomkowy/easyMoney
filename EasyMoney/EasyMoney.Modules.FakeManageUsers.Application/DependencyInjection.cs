using EasyMoney.Modules.FakeManageUsers.Application.Authenticate;
using EasyMoney.Modules.FakeManageUsers.Application.CreateUser;
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
            services.AddScoped<ISignInManager, SignInManager>();
            services.AddScoped<ITokenService, TokenService>();
            services.AddScoped<IUserManager, UserManager>();
            return services;
        }
    }
}
