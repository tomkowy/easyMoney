using System;

namespace EasyMoney.Modules.FakeStatistics.Application.GetUsersStatistics
{
    public class UserStatisticsVM
    {
        public int Count { get; set; }
        public DateTime? LastCreated { get; set; }

        public UserStatisticsVM(int count, DateTime? lastCreated)
        {
            Count = count;
            LastCreated = lastCreated;
        }
    }
}
