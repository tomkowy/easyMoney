using System;

namespace EasyMoney.Modules.FakeNotifications.Domain.Emails
{
    public class Email
    {
        public Guid Id { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string Addresses { get; set; }
    }
}
