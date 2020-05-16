using EasyMoney.Modules.FakeManageUsers.Application.GetUsersCount;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace EasyMoney.Modules.FakeStatistics.Application.GetUsersStatistics
{
    internal class GetUsersStatisticsQueryHandler : IRequestHandler<GetUsersStatisticsQuery, UserStatisticsVM>
    {
        private readonly IMediator _mediator;

        public GetUsersStatisticsQueryHandler(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<UserStatisticsVM> Handle(GetUsersStatisticsQuery request, CancellationToken cancellationToken)
        {
            //we can use GetSentEmailsCountQuery, but this example just simulate pass data between modules
            var usersCountWithLastCreatedDate = await _mediator.Send(new GetUsersCountWithLastCreatedDateQuery());
            return new UserStatisticsVM(usersCountWithLastCreatedDate.Count, usersCountWithLastCreatedDate.LastCreated);
        }
    }
}
