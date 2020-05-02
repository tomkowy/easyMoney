using MediatR;
using System;

namespace EasyMoney.Application.FakeData.Queries.GetDateNow
{
    public class GetDateNowQuery : IRequest<DateTime>
    {
    }
}
