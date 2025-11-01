using Newtonsoft.Json.Linq;
using OpenWeatherApi.Models;

namespace OpenWeatherApi.Services
{
    public class WeatherService : IWeatherService
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiKey;

        public WeatherService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _apiKey = configuration["OpenWeatherMap:ApiKey"]
                ?? throw new ArgumentNullException("OpenWeatherMap:ApiKey");
        }

        public async Task<EnvironmentInfo?> GetEnvironmentDataAsync(string city)
        {
            var geoUrl = $"http://api.openweathermap.org/geo/1.0/direct?q={city}&limit=1&appid={_apiKey}";
            var geoResponse = await _httpClient.GetStringAsync(geoUrl);
            var geoJson = JArray.Parse(geoResponse);

            if (!geoJson.Any()) return null;

            var lat = (double)geoJson[0]["lat"];
            var lon = (double)geoJson[0]["lon"];

            var weatherUrl = $"https://api.openweathermap.org/data/2.5/weather?lat={lat}&lon={lon}&appid={_apiKey}&units=metric";
            var pollutionUrl = $"http://api.openweathermap.org/data/2.5/air_pollution?lat={lat}&lon={lon}&appid={_apiKey}";

            var weatherJson = JObject.Parse(await _httpClient.GetStringAsync(weatherUrl));
            var pollutionJson = JObject.Parse(await _httpClient.GetStringAsync(pollutionUrl));

            var info = new EnvironmentInfo
            {
                City = city,
                Latitude = lat,
                Longitude = lon,
                TemperatureCelsius = (double)weatherJson["main"]["temp"],
                Humidity = (int)weatherJson["main"]["humidity"],
                WindSpeed = (double)weatherJson["wind"]["speed"],
                AirQualityIndex = (int)pollutionJson["list"][0]["main"]["aqi"],
                Pollutants = new Dictionary<string, double>
                {
                    ["pm2_5"] = (double)pollutionJson["list"][0]["components"]["pm2_5"],
                    ["pm10"] = (double)pollutionJson["list"][0]["components"]["pm10"],
                    ["co"] = (double)pollutionJson["list"][0]["components"]["co"],
                    ["no2"] = (double)pollutionJson["list"][0]["components"]["no2"],
                    ["so2"] = (double)pollutionJson["list"][0]["components"]["so2"],
                    ["o3"] = (double)pollutionJson["list"][0]["components"]["o3"]
                }
            };

            return info;
        }
    }
}
