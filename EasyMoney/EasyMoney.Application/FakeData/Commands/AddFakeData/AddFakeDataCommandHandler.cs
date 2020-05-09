using EasyMoney.Fake;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace EasyMoney.Application.FakeData.Commands.AddFakeData
{
    public class AddFakeDataCommandHandler : IRequestHandler<AddFakeDataCommand, string>
    {
        private readonly IFakeService _fakeService;

        public AddFakeDataCommandHandler(IFakeService fakeService)
        {
            _fakeService = fakeService;
        }

        public Task<string> Handle(AddFakeDataCommand request, CancellationToken cancellationToken)
        {
            throw new System.Exception();
            var addedValue = _fakeService.Add(request.Value1, request.Value2, request.Value3, request.Value4);
            return Task.FromResult(addedValue);
        }
    }
}
