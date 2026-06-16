using CyberSecurity.API.Models;
using CyberSecurity.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace CyberSecurity.API.Controllers
{
    [ApiController]
    [Route("api/request")]
    public class RequestController : ControllerBase
    {
        private readonly DetectionService _detectionService;

        public RequestController(DetectionService detectionService)
        {
            _detectionService = detectionService;
        }

        [HttpPost("analyze")]
        public IActionResult Analyze(RequestLog log)
        {
            var result = _detectionService.CheckPayload(log.Payload);

            return Ok(new
            {
                status = result,
                message = result == "Attack" ? "⚠️ Threat Detected" : "✔ Safe Request"
            });
        }
    }
}
