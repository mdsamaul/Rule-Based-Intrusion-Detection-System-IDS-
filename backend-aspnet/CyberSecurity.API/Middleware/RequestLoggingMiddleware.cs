using CyberSecurity.API.Models;
using CyberSecurity.API.Services;

namespace CyberSecurity.API.Middleware
{
    public class RequestLoggingMiddleware
    {
        private readonly RequestDelegate _next;

        public RequestLoggingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context, RequestLogService logService)
        {
            var request = context.Request;

            var log = new RequestLog
            {
                IP = context.Connection.RemoteIpAddress?.ToString(),
                Url = request.Path,
                Payload = request.QueryString.ToString(),
                Time = DateTime.Now
            };

            await logService.Log(log);

            await _next(context);
        }
    }
}
