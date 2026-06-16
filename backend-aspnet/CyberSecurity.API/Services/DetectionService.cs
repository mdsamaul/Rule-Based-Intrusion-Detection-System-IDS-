namespace CyberSecurity.API.Services
{
    public class DetectionService
    {
        public string CheckPayload(string payload)
        {
            if (payload.Contains("SELECT") ||
                payload.Contains("<script>") ||
                payload.Contains("OR 1=1"))
            {
                return "Attack";
            }

            return "Normal";
        }
    }
}
