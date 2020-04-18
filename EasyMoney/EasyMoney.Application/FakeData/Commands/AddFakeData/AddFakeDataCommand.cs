using MediatR;

namespace EasyMoney.Application.FakeData.Commands.AddFakeData
{
    public class AddFakeDataCommand : IRequest<string>
    {
        public string Value { get; set; }
    }
}
