using MediatR;
using System;

namespace EasyMoney.Modules.FakeManageUsers.Application.GetUser
{
    public class GetUserQuery : IRequest<GetUserQueryVM>
    {
        public Guid UserId { get; set; }

        public GetUserQuery(string userId)
        {
            UserId = Guid.Parse(userId);
        }
    }
}
