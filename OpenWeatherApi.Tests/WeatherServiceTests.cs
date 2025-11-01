using Microsoft.Extensions.Configuration;
using Moq;
using Moq.Protected;
using OpenWeatherApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace OpenWeatherApi.Tests
{
    public class WeatherServiceTests
    {
        [Fact]
        public async Task GetEnvironmentDataAsync_ReturnsNull_WhenCityNotFound()
        {
            var mockHandler = new Mock<HttpMessageHandler>();
            mockHandler.Protected()
                .Setup<Task<HttpResponseMessage>>(
                    "SendAsync",
                    ItExpr.IsAny<HttpRequestMessage>(),
                    ItExpr.IsAny<CancellationToken>())
                .ReturnsAsync(new HttpResponseMessage
                {
                    StatusCode = HttpStatusCode.OK,
                    Content = new StringContent("[]")
                });

            var client = new HttpClient(mockHandler.Object);
            var config = new ConfigurationBuilder()
                .AddInMemoryCollection(new Dictionary<string, string> { { "OpenWeatherMap:ApiKey", "test" } })
                .Build();

            var service = new WeatherService(client, config);

            var result = await service.GetEnvironmentDataAsync("InvalidCity");

            Assert.Null(result);
        }
    }
}
