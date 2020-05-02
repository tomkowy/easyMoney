using EasyMoney.Infrastructure.Services;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace EasyMoney.Application.FakeData.Queries.GetDateNow
{
    public class GetDateNowQueryHandler : IRequestHandler<GetDateNowQuery, DateTime>
    {
        private readonly IDateTimeService _dateTimeService;

        public GetDateNowQueryHandler(IDateTimeService dateTimeService)
        {
            _dateTimeService = dateTimeService;
        }

        public Task<DateTime> Handle(GetDateNowQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_dateTimeService.Now);
        }
    }
}
