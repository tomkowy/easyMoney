using System;

namespace EasyMoney.Modules.FakeManageUsers.Application.Authenticate
{
    public interface ITokenService
    {
        string GenerateJwtForUser(Guid userId);
    }
}
