using EasyMoney.Modules.FakeManageUsers.Application.Exceptions;
using EasyMoney.Modules.FakeManageUsers.Domain.Users;
using EasyMoney.Modules.FakeManageUsers.Infrastructure.Context;
using Microsoft.AspNetCore.Identity;
using System.Linq;
using System.Threading.Tasks;

namespace EasyMoney.Modules.FakeManageUsers.Application.Authenticate
{
    public class SignInManager : ISignInManager
    {
        private readonly SignInManager<User> _signInManager;
        private readonly ITokenService _tokenService;
        private readonly ManageUsersContext _context;

        public SignInManager(SignInManager<User> signInManager, ITokenService tokenService, ManageUsersContext context)
        {
            _signInManager = signInManager;
            _tokenService = tokenService;
            _context = context;
        }

        public async Task<string> Authenticate(string userName, string password)
        {
            var user = _context.Users.SingleOrDefault(x => x.UserName == userName);
            if (user == null)
            {
                throw new LoginOrPasswordAreIncorrectException();
            }

            var results = await _signInManager.PasswordSignInAsync(userName, password, false, false);
            if (!results.Succeeded)
            {
                throw new LoginOrPasswordAreIncorrectException();
            }

            var token = _tokenService.GenerateJwtForUser(user.Id);
            return token;
        }
    }
}
