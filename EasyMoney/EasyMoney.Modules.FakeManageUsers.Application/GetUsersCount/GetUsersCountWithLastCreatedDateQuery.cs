using MediatR;

namespace EasyMoney.Modules.FakeManageUsers.Application.GetUsersCount
{
    public class GetUsersCountWithLastCreatedDateQuery : IRequest<UserCountWithLastCreatedDateVM>
    {
    }
}
