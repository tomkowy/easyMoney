using System.Threading.Tasks;

namespace EasyMoney.Modules.FakeManageUsers.Application.Authenticate
{
    public interface ISignInManager
    {
        Task<AuthenticateUserVM> Authenticate(string userName, string password);
    }
}
