using CyberSecurity.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace CyberSecurity.API.Controllers
{
    [ApiController]
    [Route("api/detect")]
    public class DetectionController : ControllerBase
    {
        private readonly ApiClientService _apiClient;

        public DetectionController(ApiClientService apiClient)
        {
            _apiClient = apiClient;
        }

        [HttpPost]
        public async Task<IActionResult> Detect(object input)
        {
            var result = await _apiClient.GetPrediction(input);
            return Ok(result);
        }
    }

}