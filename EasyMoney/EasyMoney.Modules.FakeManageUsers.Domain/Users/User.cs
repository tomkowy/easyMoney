using Microsoft.AspNetCore.Identity;
using System;

namespace EasyMoney.Modules.FakeManageUsers.Domain.Users
{
    public class User : IdentityUser<Guid>
    {
        public bool Active { get; private set; }
        public DateTime CreatedDate { get; set; }

        public User() { }

        private User(string email)
        {
            Email = email;
            UserName = email;
            CreatedDate = DateTime.Today;
        }

        public static User Create(string email)
        {
            return new User(email);
        }

        public void Activate()
        {
            Active = true;
        }
    }
}
