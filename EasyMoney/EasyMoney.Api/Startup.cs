using Common.Configuration;
using EasyMoney.Api.Filters;
using EasyMoney.Api.StartupConfig;
using EasyMoney.Application;
using EasyMoney.Infrastructure.Services;
using EasyMoney.Modules.FakeManageUsers.Application;
using EasyMoney.Modules.FakeNotifications.Application;
using EasyMoney.Modules.FakeStatistics.Application;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace EasyMoney.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddApplication();
            services.AddFakeNotificationApplication();
            services.AddFakeStatisticsApplication();
            services.AddFakeManageUsersApplication();

            services.AddInfrastructureServices();

            services.AddControllersWithViews(options =>
                options.Filters.Add(new ApiExceptionFilter())
                );

            services.AddSwagger();
            services.AddConfiguration(Configuration);
            services.AddDatabaseConfig(Configuration.GetSection("ConnectionStrings").Get<ConnectionStrings>().DefaultConnection);

            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseEasyMoneySwagger();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
