using System;

namespace EasyMoney.Modules.FakeManageUsers.Application.Exceptions
{
    public class LoginOrPasswordAreIncorrectException : Exception
    {
        public LoginOrPasswordAreIncorrectException() : base("Login or password are incorrect")
        {
        }
    }
}
