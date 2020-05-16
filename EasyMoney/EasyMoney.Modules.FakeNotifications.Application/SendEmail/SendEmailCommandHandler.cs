using EasyMoney.Modules.FakeNotifications.Application.SendEmail.Exceptions;
using EasyMoney.Modules.FakeNotifications.Domain.Emails;
using EasyMoney.Modules.FakeNotifications.Infrastructure.Context;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace EasyMoney.Modules.FakeNotifications.Application.SendEmail
{
    internal class SendEmailCommandHandler : IRequestHandler<SendEmailCommand>
    {
        private readonly NotificationsContext _context;

        public SendEmailCommandHandler(NotificationsContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(SendEmailCommand request, CancellationToken cancellationToken)
        {
            var email = Email.Create(request.Subject, request.Body, request.Addresses);
            //for simplicity I assume that add email to the database is like sent it
            _context.Emails.Add(email);
            var value = await _context.SaveChangesAsync();
            if (value == 0)
            {
                throw new EmailWasntSentException();
            }
            return Unit.Value;
        }
    }
}
