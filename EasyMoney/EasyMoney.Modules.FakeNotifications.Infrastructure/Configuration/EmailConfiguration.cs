using EasyMoney.Modules.FakeNotifications.Domain.Emails;
using EasyMoney.Modules.FakeNotifications.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EasyMoney.Modules.FakeNotifications.Infrastructure.Configuration
{
    internal class EmailConfiguration : IEntityTypeConfiguration<Email>
    {
        public void Configure(EntityTypeBuilder<Email> builder)
        {
            builder.ToTable("Emails");

            builder.HasKey(x => x.Id);

            builder.SeedEmails();
        }
    }
}
