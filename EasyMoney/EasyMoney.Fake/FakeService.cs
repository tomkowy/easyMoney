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

        public string Add(string value)
        {
            FakeData.Add(value);
            return value;
        }
    }
}
