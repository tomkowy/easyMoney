using Domain.Entities;
using System.Linq;

namespace Persistence.Database
{
    public class EasyMoneyDbContextSeed
    {
        public static void SeedData(EasyMoneyDbContext context)
        {
            context.Database.EnsureCreated();

            if (!context.Fakes.Any())
            {
                context.Fakes.Add(new Fake
                {
                    Value = "SeedValue"
                });

                context.SaveChanges();
            }
        }
    }
}
