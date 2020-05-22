using EasyMoney.Modules.FakeManageUsers.Application.ActivateUser;
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
    }
}