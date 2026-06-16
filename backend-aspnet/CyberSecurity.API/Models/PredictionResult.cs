namespace CyberSecurity.API.Models
{
    public class PredictionResult
    {
        public string Result { get; set; }  // Attack / Normal
        public double Confidence { get; set; }
    }
}
