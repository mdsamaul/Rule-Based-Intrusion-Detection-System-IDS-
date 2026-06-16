using Microsoft.AspNetCore.Mvc;

namespace CyberSecurity.API.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class AuthController : ControllerBase
    {
        [HttpPost("login")]
        public IActionResult Login()
        {
            return Ok("Login endpoint working");
        }
    }
}
