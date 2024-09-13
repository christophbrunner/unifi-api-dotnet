using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Sample.Calls;
using UniFiApiDotnet;
using IHost = Microsoft.Extensions.Hosting.IHost;

HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);

builder.Services.AddLogging(configure => configure.AddConsole()); 

// Sample of how to use a proxy
//builder.Services.AddHttpClient("UniFiApi").ConfigurePrimaryHttpMessageHandler(() =>
//{
//    var proxy = new WebProxy
//    {
//        Address = new Uri($"http://myProxy:8081"),
//    };
//    var httpClientHandler = new HttpClientHandler
//    {
//        Proxy = proxy,
//    };
//    return httpClientHandler;
//});

builder.Services.UseUniFiApiDotnet(configure =>
{
    configure.ApiKey = "[your_api_key]"; // optional: only if you want to use ApiKey by code
    configure.HttpClientFactoryClientName = "UniFiApi"; // optional: only if you want to use named client
});

builder.Services.AddSingleton<DemoAppService>();

using IHost host = builder.Build();

await StartDemoApp(host.Services);

await host.RunAsync();

static async Task StartDemoApp(IServiceProvider hostProvider)
{
    var demoApp = hostProvider.GetRequiredService<DemoAppService>();

   await demoApp.Run();
}