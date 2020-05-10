using EasyMoney.Api.Filters;
using EasyMoney.Api.StartupConfig;
using EasyMoney.Application;
using EasyMoney.Infrastructure.Services;
using EasyMoney.Modules.FakeManageUsers.Infrastructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Persistence.Database;

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
            services.AddInfrastructureServices();

            services.AddControllersWithViews(options =>
                options.Filters.Add(new ApiExceptionFilter())
                );

            services.AddSwagger();
            //services.AddDbContext(Configuration);

            services.AddDbContext<ManageUserContext>(options =>
                    options.UseSqlServer(
                        Configuration.GetConnectionString("DefaultConnection")));
            //services.AddDbContext<EasyMoneyDbContext>(options =>
            //        options.UseSqlServer(
            //            Configuration.GetConnectionString("DefaultConnection")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, 
            //EasyMoneyDbContext dbContext, 
            ManageUserContext dbContex2t)
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

            //EasyMoneyDbContextSeed.SeedData(dbContext);
            ManageUserContextSeed.SeedData(dbContex2t);
        }
    }
}
