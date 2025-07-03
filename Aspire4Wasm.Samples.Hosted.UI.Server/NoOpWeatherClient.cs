using Aspire4Wasm.Samples.Hosted.HttpContracts;

namespace Aspire4Wasm.Samples.Hosted.UI.Server;

public class NoOpWeatherClient : IWeatherClient
{
    public async Task<WeatherForecastResponse[]> GetWeatherAsync(int maxItems = 10, CancellationToken cancellationToken = default)
    {
        return await Task.FromResult<WeatherForecastResponse[]>([]);
    }
}