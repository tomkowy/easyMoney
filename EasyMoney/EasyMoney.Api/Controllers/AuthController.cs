using EasyMoney.Modules.FakeManageUsers.Application.Authenticate;
using EasyMoney.Modules.FakeManageUsers.Application.CreateUser;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EasyMoney.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ApiController
    {
        [HttpPost]
        public async Task<IActionResult> Auth([FromBody]AuthenticateCommand command)
        {
            var result = await Mediator.Send(command);
            return Ok(result);
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create([FromBody]CreateUserCommand command)
        {
            var result = await Mediator.Send(command);
            return Ok(result);
        }
    }
}