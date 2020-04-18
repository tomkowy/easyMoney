using System.Collections.Generic;

namespace EasyMoney.Fake
{
    public interface IFakeService
    {
        string GetFirst();
        IEnumerable<string> GetAll();
        string Add(string value);
    }
}
