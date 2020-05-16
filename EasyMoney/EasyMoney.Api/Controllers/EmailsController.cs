using EasyMoney.Modules.FakeNotifications.Application.SendEmail;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EasyMoney.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailsController : ApiController
    {
        [HttpPost]
        public async Task<ActionResult<bool>> SendEmail([FromBody]SendEmailCommand command)
        {
            await Mediator.Send(command);
            return NoContent();
        }
    }
}