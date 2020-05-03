using System;
using System.Collections.Generic;
using System.Linq;

namespace EasyMoney.Fake
{
    public class FakeService : IFakeService
    {
        private List<string> FakeData = new List<string> { "first", "second", "third" };

        public IEnumerable<string> GetAll()
        {
            return FakeData;
        }

        public string GetFirst()
        {
            return FakeData.First();
        }

        public string Add(string value1, int value2, DateTime valu3, IEnumerable<string> value4)
        {
            FakeData.Add(value1);
            return value1;
        }
    }
}
