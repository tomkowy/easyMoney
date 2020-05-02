using EasyMoney.Application.FakeData.Commands.AddFakeData;
using EasyMoney.Application.FakeData.Queries.GetDateNow;
using EasyMoney.Application.FakeData.Queries.GetFirstFakeData;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EasyMoney.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FakeController : ApiController
    {
        [HttpGet]
        public async Task<IActionResult> GetFirstFakeData()
        {
            var query = new GetFirstFakeDataQuery();
            return Ok(await Mediator.Send(query));
        }

        [HttpPost]
        public async Task<IActionResult> AddFakeData([FromBody] AddFakeDataCommand command)
        {
            return Ok(await Mediator.Send(command));
        }

        [HttpGet("date")]
        public async Task<IActionResult> GetDateNow()
        {
            var query = new GetDateNowQuery();
            return Ok(await Mediator.Send(query));
        }
    }
}