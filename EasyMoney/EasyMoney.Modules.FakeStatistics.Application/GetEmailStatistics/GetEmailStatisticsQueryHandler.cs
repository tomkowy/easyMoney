using EasyMoney.Modules.FakeNotifications.Application.GetSentEmailsCount;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace EasyMoney.Modules.FakeStatistics.Application.GetEmailStatistics
{
    public class GetEmailStatisticsQueryHandler : IRequestHandler<GetEmailStatisticsQuery, int>
    {
        private readonly IMediator _medaitor;

        public GetEmailStatisticsQueryHandler(IMediator medaitor)
        {
            _medaitor = medaitor;
        }

        public async Task<int> Handle(GetEmailStatisticsQuery request, CancellationToken cancellationToken)
        {
            //we can use GetSentEmailsCountQuery, but this example just simulate pass data between modules
            var count = await _medaitor.Send(new GetSentEmailsCountQuery());
            return count;
        }
    }
}
