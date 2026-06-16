using CyberSecurity.API.Data;
using CyberSecurity.API.Models;

namespace CyberSecurity.API.Services
{
    public class RequestLogService
    {
        private readonly AppDbContext _context;

        public RequestLogService(AppDbContext context)
        {
            _context = context;
        }

        public async Task Log(RequestLog log)
        {
            _context.RequestLogs.Add(log);
            await _context.SaveChangesAsync();
        }
    }
}
