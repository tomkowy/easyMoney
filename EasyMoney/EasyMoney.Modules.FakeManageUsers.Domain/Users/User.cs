using System;

namespace EasyMoney.Modules.FakeManageUsers.Domain.Users
{
    public class User
    {
        public Guid Id { get; private set; }
        public string Email { get; private set; }
        public bool Active { get; private set; }

        private User() { }

        private User(string email)
        {
            Email = email;
        }

        internal static User Create(string email)
        {
            return new User(email);
        }

        internal void Activate()
        {
            Active = true;
        }
    }
}
