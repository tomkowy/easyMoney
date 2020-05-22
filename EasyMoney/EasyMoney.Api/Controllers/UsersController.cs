using EasyMoney.Modules.FakeManageUsers.Application.ActivateUser;
using EasyMoney.Modules.FakeManageUsers.Application.GetUser;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EasyMoney.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ApiController
    {
        [HttpPost("activate")]
        public async Task<ActionResult> ActivateUser([FromBody]ActivateUserCommand command)
        {
            await Mediator.Send(command);
            return NoContent();
        }

        [HttpGet("{userId}")]
        public async Task<ActionResult<GetUserQueryVM>> Get([FromRoute]string userId)
        {
            var user = await Mediator.Send(new GetUserQuery(userId));
            return Ok(user);
        }
    }
}