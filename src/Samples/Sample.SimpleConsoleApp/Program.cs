using System.Net;
using Sample.Calls;
using UniFiApiDotnet;
using UniFiApiDotnet.Abstraction;

IUniFiApiService uniFiApiService = new UniFiApiService("[your_api_key]");


// Sample with proxy
// Create a proxy
//var proxy = new WebProxy
//{
//    Address = new Uri($"http://myProxy:8081"),
//};

// Create a client handler that uses the proxy
//var httpClientHandler = new HttpClientHandler
//{
//    Proxy = proxy,
//};

// Finally, create the HTTP client object
//var client = new HttpClient(handler: httpClientHandler, disposeHandler: true);

// Create the service with the client
///IUniFiApiService uniFiApiService = new UniFiApiService(client, "[your_api_key]");



//optional: set the api key after the service has been created
//IUniFiApiService uniFiApiService = new UniFiApiService();
//uniFiApiService.SetApiKey("[your_api_key]"); 


try
{
    var demoAppService = new DemoAppService(uniFiApiService);
    await demoAppService.Run();
}
catch (Exception e)
{
    Console.WriteLine(e);
    Console.ReadLine();
}