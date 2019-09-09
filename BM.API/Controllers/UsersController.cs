using System;
using System.Linq;
using System.Threading.Tasks;
using BM.Core.Service;
using BM.Domain.Models;
using BM.Toolkit.Messages;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BM.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUsersService _usersService;

        public UsersController(IUsersService userService)
        {
            this._usersService = userService;
        }

        // Post api/login
        [AllowAnonymous]
        [HttpPost("authenticate")]
        public async Task<IActionResult> Authenticate([FromBody]LoginModel model)
        {
            try
            {
                var result = await _usersService.AuthenticateAsync(model);
                if (result == null)
                    return BadRequest(UsersMessages.InvalidUsernameOrPassword);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
