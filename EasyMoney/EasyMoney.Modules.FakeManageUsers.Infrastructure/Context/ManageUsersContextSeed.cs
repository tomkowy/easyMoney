using EasyMoney.Modules.FakeManageUsers.Domain.Users;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace EasyMoney.Modules.FakeManageUsers.Infrastructure.Context
{
    internal static class ManageUsersContextSeed
    {
        public static void SeedUser(this EntityTypeBuilder<User> builder)
        {
            builder.HasData(new { Id = Guid.NewGuid(), Email = "email@com.pl", Active = true, CreatedDate = DateTime.Today });
        }
    }
}
