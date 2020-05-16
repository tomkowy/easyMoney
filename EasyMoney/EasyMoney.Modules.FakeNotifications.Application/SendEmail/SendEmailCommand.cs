using MediatR;

namespace EasyMoney.Modules.FakeNotifications.Application.SendEmail
{
    public class SendEmailCommand : IRequest
    {
        public string Subject { get; set; }
        public string Body { get; set; }
        public string Addresses { get; set; }
    }
}
