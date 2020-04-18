using System.Collections.Generic;

namespace EasyMoney.Fake
{
    public interface IFakeService
    {
        string GetFirst();
        IEnumerable<string> GetAll();
        void Add(string value);
    }
}
