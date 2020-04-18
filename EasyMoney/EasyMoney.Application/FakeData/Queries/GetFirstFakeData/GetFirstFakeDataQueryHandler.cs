using EasyMoney.Fake;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace EasyMoney.Application.FakeData.Queries.GetFirstFakeData
{
    public class GetFirstFakeDataQueryHandler : IRequestHandler<GetFirstFakeDataQuery, string>
    {
        private readonly IFakeService _fakeService;

        public GetFirstFakeDataQueryHandler(IFakeService fakeService)
        {
            _fakeService = fakeService;
        }

        public Task<string> Handle(GetFirstFakeDataQuery request, CancellationToken cancellationToken)
        {
            var fakeData = _fakeService.GetFirst();
            return Task.FromResult(fakeData);
        }
    }
}
