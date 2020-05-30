using Microsoft.AspNetCore.Identity;
using System;

namespace EasyMoney.Modules.FakeManageUsers.Domain.Users
{
    public class User : IdentityUser<Guid>
    {
        public bool Active { get; private set; }
        public DateTime CreatedDate { get; set; }

        public User() { }

        private User(string email, string name)
        {
            Email = email;
            UserName = name;
            CreatedDate = DateTime.Today;
        }

        public static User Create(string email, string name)
        {
            return new User(email, name);
        }

        public void Activate()
        {
            Active = true;
        }
    }
}
