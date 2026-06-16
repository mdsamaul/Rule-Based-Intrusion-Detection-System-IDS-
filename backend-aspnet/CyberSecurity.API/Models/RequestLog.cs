namespace CyberSecurity.API.Models
{
    public class RequestLog
    {
        public int Id { get; set; }
        public string IP { get; set; }
        public string Url { get; set; }
        public string Payload { get; set; }
        public DateTime Time { get; set; }
    }
}
