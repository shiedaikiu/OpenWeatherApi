using OpenWeatherApi.Models;

namespace OpenWeatherApi.Services
{
    public interface IWeatherService
    {
        Task<EnvironmentInfo?> GetEnvironmentDataAsync(string city);
    }
}
