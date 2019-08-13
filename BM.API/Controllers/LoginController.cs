using System;
using System.Linq;
using BM.Core.Service;
using BM.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace BM.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginService loginService;

        public LoginController(ILoginService loginService)
        {
            this.loginService = loginService;
        }

        // Post api/login
        [HttpPost()]
        public ActionResult<LoginResultModel> Get([FromBody]LoginModel model)
        {
            try
            {
                return Ok(new LoginResultModel { Message = "Success" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
