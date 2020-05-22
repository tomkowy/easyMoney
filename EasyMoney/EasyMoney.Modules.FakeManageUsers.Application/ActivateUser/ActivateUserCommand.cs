using MediatR;
using System;

namespace EasyMoney.Modules.FakeManageUsers.Application.ActivateUser
{
    public class ActivateUserCommand : IRequest
    {
        public Guid UserId { get; set; }
    }
}
