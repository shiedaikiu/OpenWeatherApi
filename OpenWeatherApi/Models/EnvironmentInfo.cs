namespace OpenWeatherApi.Models
{
    public class EnvironmentInfo
    {
        public string City { get; set; } = string.Empty;
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public double TemperatureCelsius { get; set; }
        public int Humidity { get; set; }
        public double WindSpeed { get; set; }
        public int AirQualityIndex { get; set; }
        public Dictionary<string, double> Pollutants { get; set; } = new();
    }
}
