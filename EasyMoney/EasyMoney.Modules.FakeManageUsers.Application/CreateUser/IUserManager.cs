using System;
using System.Threading.Tasks;

namespace EasyMoney.Modules.FakeManageUsers.Application.CreateUser
{
    public interface IUserManager
    {
        //todo delete user name, validate unique email
        Task<Guid> CreateAccount(string userName, string email, string password);
    }
}
