using Microsoft.AspNetCore.Mvc;
using WebApi.Application.Services;
using WebApi.Domain.Model.EmployeeAggregate;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/v1/auth")]
    //[Route("api/v{version:apiVersion}/auth")]
    public class AuthController : Controller
    {
        [HttpPost]
        public IActionResult Auth(string username, string password)
        {
            if (username == "gustavo" && password == "123456")
            {
                var token = TokenServices.GenerateToken(new Employee());

                return Ok(token);
            }
            return BadRequest("username or password invalid");
        }
    }
}
