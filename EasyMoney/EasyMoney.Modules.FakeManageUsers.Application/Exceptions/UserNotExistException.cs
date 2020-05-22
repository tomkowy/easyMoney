using System;

namespace EasyMoney.Modules.FakeManageUsers.Application.Exceptions
{
    public class UserNotExistException : Exception
    {
        public UserNotExistException(Guid userId) : base($"User with Id '{userId}' not exist")
        {
        }
    }
}
