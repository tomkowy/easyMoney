using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Persistence.Database
{
    public class EasyMoneyDbContext : DbContext
    {
        public DbSet<Fake> Fakes { get; set; }

        public EasyMoneyDbContext(DbContextOptions<EasyMoneyDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(builder);
        }
    }
}
