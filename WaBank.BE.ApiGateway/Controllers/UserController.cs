using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WaBank.BE.ApiGateway.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class UserController : ControllerBase
    {
        [HttpPost]
        [AllowAnonymous]
        public Task<ActionResult> Login(/*some model here*/)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public Task<ActionResult> LogOut()
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        [AllowAnonymous]
        public Task<ActionResult> Register(/*model*/)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        [AllowAnonymous]
        public Task<ActionResult> RegisterConfirmed(/*model*/)
        {
            throw new NotImplementedException();
        }
    }
}
