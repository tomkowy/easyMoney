using MediatR;

namespace EasyMoney.Modules.FakeManageUsers.Application.CreateUser
{
    public class CreateUserCommand : IRequest<CreateUserVM>
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
