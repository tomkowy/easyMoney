using EasyMoney.Modules.FakeManageUsers.Domain.Users;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace EasyMoney.Modules.FakeManageUsers.Infrastructure
{
    public class ManageUserContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public ManageUserContext(DbContextOptions<ManageUserContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }
    }
}
