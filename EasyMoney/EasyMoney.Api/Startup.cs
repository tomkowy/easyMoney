using EasyMoney.Api.StartupConfig;
using EasyMoney.Application;
using EasyMoney.Infrastructure.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Server.Kestrel.Core;
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
            services.Configure<KestrelServerOptions>(options =>
            {
                options.AllowSynchronousIO = true;
            });

            // If using IIS:
            services.Configure<IISServerOptions>(options =>
            {
                options.AllowSynchronousIO = true;
            });

            services.AddMvc(options =>
            {
                options.Filters.Add(new Filters.ApiExceptionFilter());
                //options.Filters.Add<Filters.ApiExceptionFilter>();
            });

            services.AddControllers();
            services.AddApplication();
            services.AddInfrastructureServices();


            //services.AddTransient<Filters.ApiExceptionFilter>();



            //services.AddControllersWithViews(options =>
            //    options.Filters.Add(new ApiExceptionFilter())
            //    );

            services.AddSwagger();
            services.AddDbContext(Configuration);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, EasyMoneyDbContext dbContext)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMiddleware<Middlewares.HandleExceptionMiddleware>();

            app.UseEasyMoneySwagger();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            EasyMoneyDbContextSeed.SeedData(dbContext);
        }
    }
}
