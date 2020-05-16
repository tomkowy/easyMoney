using System;

namespace EasyMoney.Modules.FakeNotifications.Domain.Emails
{
    public class Email
    {
        public Guid Id { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string Addresses { get; set; }

        private Email() { }

        private Email(string subject, string body, string addresses)
        {
            Subject = subject;
            Body = body;
            Addresses = addresses;
        }

        public static Email Create(string subject, string body, string addresses)
        {
            return new Email(subject, body, addresses);
        }
    }
}
