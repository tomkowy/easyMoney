using System;
using System.Threading.Tasks;

namespace EasyMoney.Modules.FakeManageUsers.Application.CreateUser
{
    public interface IUserManager
    {
        Task<Guid> CreateAccount(string email, string password);
    }
}
