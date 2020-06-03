using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace EasyMoney.Modules.FakeManageUsers.Application.Authenticate
{
    public class AuthenticateCommandHandler : IRequestHandler<AuthenticateCommand, AuthenticateUserVM>
    {
        private readonly ISignInManager _signInManager;

        public AuthenticateCommandHandler(ISignInManager signInManager)
        {
            _signInManager = signInManager;
        }

        public async Task<AuthenticateUserVM> Handle(AuthenticateCommand request, CancellationToken cancellationToken)
        {
            var token = await _signInManager.Authenticate(request.UserName, request.Password);
            return new AuthenticateUserVM(request.UserName, token);
        }
    }
}
