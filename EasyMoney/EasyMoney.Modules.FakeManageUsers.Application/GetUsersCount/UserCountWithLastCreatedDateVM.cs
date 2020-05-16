using System;

namespace EasyMoney.Modules.FakeManageUsers.Application.GetUsersCount
{
    public class UserCountWithLastCreatedDateVM
    {
        public int Count { get; set; }
        public DateTime? LastCreated { get; set; }

        public UserCountWithLastCreatedDateVM(int count, DateTime? lastCreated)
        {
            Count = count;
            LastCreated = lastCreated;
        }
    }
}
