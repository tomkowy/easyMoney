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
    }
}