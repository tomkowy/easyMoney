using EasyMoney.Modules.FakeManageUsers.Domain.Users;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace EasyMoney.Modules.FakeManageUsers.Infrastructure.Context
{
    internal static class ManageUserContextSeed
    {
        public static void SeedUser(this EntityTypeBuilder<User> builder)
        {
            builder.HasData(new { Id = Guid.NewGuid(), Email = "email@com.pl", Active = true });
        }
    }
}
