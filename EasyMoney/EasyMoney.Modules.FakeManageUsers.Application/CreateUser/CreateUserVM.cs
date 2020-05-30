using System;

namespace EasyMoney.Modules.FakeManageUsers.Application.CreateUser
{
    public class CreateUserVM
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public CreateUserVM(Guid id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
        }
    }
}
