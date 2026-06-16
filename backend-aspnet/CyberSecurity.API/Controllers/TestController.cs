using Microsoft.AspNetCore.Mvc;

namespace CyberSecurity.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {
       
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Cyber Security API is running 🚀");
        }
    }
}
