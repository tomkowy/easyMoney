using EasyMoney.Modules.FakeNotifications.Application.GetSentEmailsCount;
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
            var count = await Mediator.Send(new GetSentEmailsCountQuery());
            return Ok(count);
        }
    }
}