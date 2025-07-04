using Aspire4Wasm.Samples.Hosted.UI;
using Aspire4Wasm.Samples.Hosted.UI.Client;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.AddServiceDefaults();
builder.Services.AddHttpClient<IWeatherClient, WeatherApiClient>(client => client.BaseAddress = new Uri("https+http://api"));

await builder.Build().RunAsync();
