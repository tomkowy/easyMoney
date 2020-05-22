using EasyMoney.Modules.FakeManageUsers.Application.Exceptions;
using EasyMoney.Modules.FakeManageUsers.Infrastructure.Context;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace EasyMoney.Modules.FakeManageUsers.Application.ActivateUser
{
    internal class ActivateUserCommandHandler : IRequestHandler<ActivateUserCommand>
    {
        private readonly ManageUsersContext _context;

        public ActivateUserCommandHandler(ManageUsersContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(ActivateUserCommand request, CancellationToken cancellationToken)
        {
            var user = _context.Users.SingleOrDefault(x => x.Id == request.UserId);
            if (user == null)
            {
                throw new UserNotExistException(request.UserId);
            }
            user.Activate();
            await _context.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
