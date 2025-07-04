# Aspire4Wasm.Samples.Hosted

Demonstrates how Aspire4Wasm makes .NET Aspire work with hosted Blazor WebAssembly apps.

Note that, even with the new "Blazor United" template, as soon as you select InteractiveAuto as the default rendermode for your Blazor Web App project, it ceases to be "united". It will be divided into two projects, just like a hosted WebAssembly project. I'm not saying that's wrong. It just does. Aspire4Wasm works the same way for both.

## Other Aspire4Wasm samples
* Aspire + WebAPI + Hosted Blazor WebAssembly + Bootstrap: https://github.com/BenjaminCharlton/Aspire4Wasm.Samples.Hosted
* Aspire + WebAPI + Standalone Blazor WebAssembly + Bootstrap: https://github.com/BenjaminCharlton/Aspire4Wasm.Samples.Standalone
* Aspire + WebAPI + Hosted Blazor WebAssembly + MudBlazor: https://github.com/BenjaminCharlton/Aspire4Wasm.Samples.Hosted.Mud
* Aspire + WebAPI + Standalone Blazor WebAssembly + MudBlazor: https://github.com/BenjaminCharlton/Aspire4Wasm.Samples.Standalone.Mud

## Learn more about Aspire4Wasm

Learn more about Aspire4Wasm here: https://github.com/BenjaminCharlton/Aspire4Wasm

## Or just jump straight in with the Nuget packages

1. For your AppHost project: https://www.nuget.org/packages/Aspire4Wasm.AppHost/ (essential)
2. For your WebAssembly project: https://www.nuget.org/packages/Aspire4Wasm.WebAssembly/ (helpful, but you can write the helper methods yourself if you prefer)
3. For your WebApi project: https://www.nuget.org/packages/Aspire4Wasm.WebApi/ (optional, if you need to configure CORS)
