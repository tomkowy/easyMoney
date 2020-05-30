using MediatR;

namespace EasyMoney.Modules.FakeManageUsers.Application.Authenticate
{
    public class AuthenticateCommand : IRequest<AuthenticateUserVM>
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
