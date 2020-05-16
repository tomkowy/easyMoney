using EasyMoney.Modules.FakeManageUsers.Infrastructure.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace EasyMoney.Modules.FakeManageUsers.Application.GetUsersCount
{
    internal class GetUsersCountWithLastCreatedDateQueryHandler : IRequestHandler<GetUsersCountWithLastCreatedDateQuery, UserCountWithLastCreatedDateVM>
    {
        private readonly ManageUsersContext _context;

        public GetUsersCountWithLastCreatedDateQueryHandler(ManageUsersContext context)
        {
            _context = context;
        }

        public async Task<UserCountWithLastCreatedDateVM> Handle(GetUsersCountWithLastCreatedDateQuery request, CancellationToken cancellationToken)
        {
            var count = await _context.Users.CountAsync();
            var lastCreated = await _context.Users.OrderByDescending(x => x.CreatedDate).FirstOrDefaultAsync();
            return new UserCountWithLastCreatedDateVM(count, lastCreated?.CreatedDate);
        }
    }
}
