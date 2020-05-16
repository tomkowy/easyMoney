using EasyMoney.Modules.FakeStatistics.Application.GetEmailStatistics;
using EasyMoney.Modules.FakeStatistics.Application.GetUsersStatistics;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EasyMoney.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatisticsController : ApiController
    {
        [HttpGet("emails/sent/count")]
        public async Task<ActionResult<int>> GetSentEmailsCount()
        {
            var count = await Mediator.Send(new GetEmailStatisticsQuery());
            return Ok(count);
        }

        [HttpGet("users/count")]
        public async Task<ActionResult<UserStatisticsVM>> GetUsersCount()
        {
            var count = await Mediator.Send(new GetUsersStatisticsQuery());
            return Ok(count);
        }
    }
}