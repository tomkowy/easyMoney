using System;

namespace EasyMoney.Modules.FakeManageUsers.Application.Exceptions
{
    public class NotUniqueEmailException : Exception
    {
        public NotUniqueEmailException(string email) : base($"Email '{email}' is not unique")
        {
        }
    }
}
