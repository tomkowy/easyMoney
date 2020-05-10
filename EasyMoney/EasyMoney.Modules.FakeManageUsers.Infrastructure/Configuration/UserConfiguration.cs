using EasyMoney.Modules.FakeManageUsers.Domain.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace EasyMoney.Modules.FakeManageUsers.Infrastructure.Configuration
{
    internal class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users", "EasyMoney");

            builder.HasKey(x => x.Id);
        }
    }
}
