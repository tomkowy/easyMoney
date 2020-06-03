using EasyMoney.Modules.FakeManageUsers.Application.Exceptions;
using EasyMoney.Modules.FakeManageUsers.Domain.Users;
using EasyMoney.Modules.FakeManageUsers.Infrastructure.Context;
using Microsoft.AspNetCore.Identity;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace EasyMoney.Modules.FakeManageUsers.Application.CreateUser
{
    public class UserManager : IUserManager
    {
        private readonly UserManager<User> _userManager;
        private readonly ManageUsersContext _context;

        public UserManager(UserManager<User> userManager, ManageUsersContext context)
        {
            _userManager = userManager;
            _context = context;
        }

        public async Task<Guid> CreateAccount(string email, string password)
        {
            var user = _context.Users.SingleOrDefault(x => x.Email == email);
            if (user != null)
            {
                throw new NotUniqueEmailException(email);
            }

            var newUser = User.Create(email);
            var result = await _userManager.CreateAsync(newUser, password);
            if (!result.Succeeded)
            {
                //todo fix global catch for this exception
                throw new CreateUserException(result.Errors);
            }
            return newUser.Id;
        }
    }
}
