using MediatR;

namespace EasyMoney.Modules.FakeStatistics.Application.GetUsersStatistics
{
    public class GetUsersStatisticsQuery : IRequest<UserStatisticsVM>
    {
    }
}
