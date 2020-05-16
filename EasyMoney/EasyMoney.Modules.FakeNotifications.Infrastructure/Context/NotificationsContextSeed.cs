using EasyMoney.Modules.FakeNotifications.Domain.Emails;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace EasyMoney.Modules.FakeNotifications.Infrastructure.Context
{
    public static class NotificationsContextSeed
    {
        public static void SeedEmails(this EntityTypeBuilder<Email> builder)
        {
            builder.HasData(new { Id = Guid.NewGuid(), Subject = "Perfect subject!", Body = "lorem ipsum, lorem ipsum", Addresses = "email1@com.pl;email2@com.pl;email3@com.pl" });
        }
    }
}
