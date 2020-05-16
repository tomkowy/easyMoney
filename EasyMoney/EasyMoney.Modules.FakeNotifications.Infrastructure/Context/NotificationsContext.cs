using Common.Configuration;
using EasyMoney.Modules.FakeNotifications.Domain.Emails;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Reflection;

namespace EasyMoney.Modules.FakeNotifications.Infrastructure.Context
{
    public class NotificationsContext : DbContext
    {
        public DbSet<Email> Emails { get; set; }

        private readonly ConnectionStrings _config;
        private const string Schema = "Notifications";

        public NotificationsContext(IOptions<ConnectionStrings> config, DbContextOptions<NotificationsContext> options) : base(options)
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
