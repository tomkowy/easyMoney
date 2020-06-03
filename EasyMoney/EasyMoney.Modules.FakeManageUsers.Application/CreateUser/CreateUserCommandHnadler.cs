using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace EasyMoney.Modules.FakeManageUsers.Application.CreateUser
{
    public class CreateUserCommandHnadler : IRequestHandler<CreateUserCommand, CreateUserVM>
    {
        private readonly IUserManager _userManager;

        public CreateUserCommandHnadler(IUserManager userManager)
        {
            _userManager = userManager;
        }

        public async Task<CreateUserVM> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var userId = await _userManager.CreateAccount(request.Email, request.Password);
            return new CreateUserVM(userId, request.Email);
        }
    }
}
