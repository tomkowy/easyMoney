using EasyMoney.Modules.FakeManageUsers.Application.Exceptions;
using EasyMoney.Modules.FakeManageUsers.Infrastructure.Context;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace EasyMoney.Modules.FakeManageUsers.Application.GetUser
{
    internal class GetUserQueryHandler : IRequestHandler<GetUserQuery, GetUserQueryVM>
    {
        private readonly ManageUsersContext _context;

        public GetUserQueryHandler(ManageUsersContext context)
        {
            _context = context;
        }

        public Task<GetUserQueryVM> Handle(GetUserQuery request, CancellationToken cancellationToken)
        {
            var user = _context.Users.SingleOrDefault(x => x.Id == request.UserId);
            if (user == null)
            {
                throw new UserNotExistException(request.UserId);
            }
            return Task.FromResult(new GetUserQueryVM(user.Email, user.Active));
        }
    }
}
