namespace CyberSecurity.API.Services
{
    public class ApiClientService
    {
        private readonly HttpClient _httpClient;

        public ApiClientService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> GetPrediction(object data)
        {
            var response = await _httpClient.PostAsJsonAsync(
                "http://localhost:5000/predict", data);

            return await response.Content.ReadAsStringAsync();
        }
    }
}
