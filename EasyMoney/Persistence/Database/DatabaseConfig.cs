using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Persistence.Database
{
    public static class DatabaseConfig
    {
        public static void AddDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<EasyMoneyDbContext>(options =>
                    options.UseSqlServer(
                        configuration.GetConnectionString("DefaultConnection")));//,
                                                                                 //b => b.MigrationsAssembly(typeof(EasyMoneyDbContext).Assembly.FullName)));
        }
    }
}
