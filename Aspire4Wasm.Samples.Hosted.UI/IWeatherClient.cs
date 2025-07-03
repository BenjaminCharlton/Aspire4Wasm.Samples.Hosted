using Aspire4Wasm.Samples.Hosted.HttpContracts;

namespace Aspire4Wasm.Samples.Hosted.UI;
public interface IWeatherClient
{
    Task<WeatherForecastResponse[]> GetWeatherAsync(int maxItems = 10, CancellationToken cancellationToken = default);
}
