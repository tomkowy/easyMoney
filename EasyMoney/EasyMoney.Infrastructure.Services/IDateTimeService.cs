using System;

namespace EasyMoney.Infrastructure.Services
{
    public interface IDateTimeService
    {
        DateTime Now { get; }
        DateTime Today { get; }
    }
}
