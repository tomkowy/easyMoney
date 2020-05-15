using Common.Configuration;
using EasyMoney.Modules.FakeManageUsers.Domain.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Reflection;

namespace EasyMoney.Modules.FakeManageUsers.Infrastructure.Context
{
    public class ManageUserContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        private readonly ConnectionStrings _config;
        private const string Schema = "ManageUser";

        public ManageUserContext(IOptions<ConnectionStrings> config, DbContextOptions<ManageUserContext> options) : base(options)
        {
            _config = config.Value;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_config.DefaultConnection, options =>
            {
                options.MigrationsHistoryTable("__MigrationsHistory", Schema);
            });
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema(Schema);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }
    }
}
