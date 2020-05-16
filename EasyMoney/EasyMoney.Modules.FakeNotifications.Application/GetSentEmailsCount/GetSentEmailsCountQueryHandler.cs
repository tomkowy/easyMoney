using EasyMoney.Modules.FakeNotifications.Infrastructure.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace EasyMoney.Modules.FakeNotifications.Application.GetSentEmailsCount
{
    internal class GetSentEmailsCountQueryHandler : IRequestHandler<GetSentEmailsCountQuery, int>
    {
        private readonly NotificationsContext _context;

        public GetSentEmailsCountQueryHandler(NotificationsContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(GetSentEmailsCountQuery request, CancellationToken cancellationToken)
        {
            var count = await _context.Emails.CountAsync();
            return count;
        }
    }
}
