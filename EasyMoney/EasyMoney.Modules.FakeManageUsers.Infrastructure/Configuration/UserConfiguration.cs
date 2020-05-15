using EasyMoney.Modules.FakeManageUsers.Domain.Users;
using EasyMoney.Modules.FakeManageUsers.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace EasyMoney.Modules.FakeManageUsers.Infrastructure.Configuration
{
    internal class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");

            builder.HasKey(x => x.Id);

            builder.SeedUser();
        }
    }
}
