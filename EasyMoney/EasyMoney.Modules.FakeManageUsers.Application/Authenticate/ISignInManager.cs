using System.Threading.Tasks;

namespace EasyMoney.Modules.FakeManageUsers.Application.Authenticate
{
    public interface ISignInManager
    {
        Task<string> Authenticate(string userName, string password);
    }
}
