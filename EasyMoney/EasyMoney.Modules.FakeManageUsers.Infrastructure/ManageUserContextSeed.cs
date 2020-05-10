using EasyMoney.Modules.FakeManageUsers.Domain.Users;
using System.Linq;

namespace EasyMoney.Modules.FakeManageUsers.Infrastructure
{
    public class ManageUserContextSeed
    {
        public static void SeedData(ManageUserContext context)
        {
            context.Database.EnsureCreated();

            if (!context.Users.Any())
            {
                context.Users.Add(User.Create("mail@mail.com"));

                context.SaveChanges();
            }
        }
    }
}
