using System;
using System.Collections.Generic;

namespace EasyMoney.Fake
{
    public interface IFakeService
    {
        string GetFirst();
        IEnumerable<string> GetAll();
        string Add(string value1, int value2, DateTime value3, IEnumerable<string> value4);
    }
}
