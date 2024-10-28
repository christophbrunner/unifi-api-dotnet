UniFi API dotnet Client
=======================

A .NET (netstandard) client for the official UniFi API.  Provides asynchronous API operations.

The client is suitable for dependency injection (DI) and for classic applications.

[![NuGet](https://img.shields.io/nuget/v/UniFiApiDotnet.svg)](https://www.nuget.org/packages/UniFiApiDotnet/)

[![Continuous Integration (CI)](https://github.com/christophbrunner/unifi-api-dotnet/actions/workflows/ci.yml/badge.svg)](https://github.com/christophbrunner/unifi-api-dotnet/actions/workflows/ci.yml)

The UniFi API
-------------
The official UniFi API is developed by Ubiquiti Networks created to enable developers to programmatically monitor and manage UniFi deployments at scale.

UniFi API Version 0.1 centers around extracting data from the UniFi Site Manager (unifi.ui.com). Future versions will expand support to include more granular configurations, allowing management of individual sites and the devices within those sites.

The original documentation can be found at https://developer.ui.com/unifi-api/.

Usage
-----

Simple and easy to use, the UniFi API dotnet Client provides a set of methods to interact with the UniFi API.

```csharp
IUniFiApiService uniFiApiService = new UniFiApiService();
//e.g. get all UniFi devices
var sites = await uniFiApiService.GetDevices();
```

To use the client with dependency injection (DI), the service can simply be registered.

```csharp
// Register the service in the service container
builder.Services.UseUniFiApiDotnet();
```
And injected into the service class.
```csharp
// Inject the service into the service class
public class YourService
{
    private readonly IUniFiApiService _uniFiApiService;

    public YourService(IUniFiApiService uniFiApiService)
    {
        _uniFiApiService = uniFiApiService;
    }

    public async Task YourMethode()
    {
        var devices = await _uniFiApiService.GetDevices();
        //...
    }
}
```

API Coverage
------------


| |Complete?|API Method|
|:---|:---:|:---|
| [List Hosts](https://developer.ui.com/unifi-api/get__ea_hosts/) | :heavy_check_mark: | `GetHosts()` |
| [Get Host by ID](https://developer.ui.com/unifi-api/get__ea_hosts_id/) | :heavy_check_mark: | `GetHostById(x)` |
| [List Sites](https://developer.ui.com/unifi-api/get__ea_sites/) | :heavy_check_mark:  | `GetSites()`  |
| [List Devices](https://developer.ui.com/unifi-api/get__ea_devices/) | :heavy_check_mark:  | `GetDevices(x)`  |
| [Get ISP Metrics](https://developer.ui.com/unifi-api/get__ea_isp-metrics_type/) | :heavy_check_mark:  | `GetIspMetrics(x)`  |
| [Query ISP Metrics](https://developer.ui.com/unifi-api/post__ea_isp-metrics_type_query/) | :heavy_check_mark:  | `QueryIspMetrics(x)`  |

Authentication
--------------
The UniFi API use a API key for authentication.
The API key can be created in the UniFi [Site Manager > API](https://unifi.ui.com/api).

The API key can be initialized via different variants.

Initialize the API key via Code
```csharp
// Initialize the API key via the constructor
IUniFiApiService uniFiApiService = new UniFiApiService("[your_api_key]");
```
or
```csharp
// Initialize the API key via a method
IUniFiApiService uniFiApiService = new UniFiApiService();
uniFiApiService.SetApiKey("[your_api_key]");
```
or initialize the API key via the appsettings.json file
```json
{
  "UniFiApi": {
    "ApiKey": "[your_api_key]"
  }
}
```
or initialization during service registration for dependency injection (DI)

```csharp
// Initialize the API key on service registration
builder.Services.UseUniFiApiDotnet(configure =>
{
    configure.ApiKey = "[your_api_key]";
});
```

The API key is stored in the `UniFiApiService` class and is used for all subsequent API calls.

[HttpClient](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpclient) / [WebProxy](https://learn.microsoft.com/de-de/dotnet/api/system.net.webproxy)
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

By default, a HttpClient is created internally.
It is also possible to specify a specific HttpClient with specific configurations.

Use specific HttpClient (e.g. with Proxy) via the constructor
```csharp
var proxy = new WebProxy
{
    Address = new Uri($"http://myProxy:8081"),
};

var httpClientHandler = new HttpClientHandler
{
    Proxy = proxy,
};

var client = new HttpClient(handler: httpClientHandler, disposeHandler: true);

// Set the HttpClient via the constructor (optional with API key)
IUniFiApiService uniFiApiService = new UniFiApiService(client);
// or optional with API key
IUniFiApiService uniFiApiService = new UniFiApiService(client, "[your_api_key]");
```

or with dependency injection (DI), register a named HttpClient (e.g. with Proxy) in the service container

```csharp
builder.Services.AddHttpClient("UniFiApi").ConfigurePrimaryHttpMessageHandler(() =>
{
    var proxy = new WebProxy
    {
        Address = new Uri($"http://myProxy:8081"),
    };
    var httpClientHandler = new HttpClientHandler
    {
        Proxy = proxy,
    };

    return httpClientHandler;
});

builder.Services.UseUniFiApiDotnet();
```

Logging (optional)
------------------

The client uses the [Microsoft.Extensions.Logging](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.logging) framework for logging.

Bugs and Feedback
-----------------
The UniFi API is unfortunately not fully documented by UniFi.
The current implementation of the service is based on demo data and data from customers. 

If you miss something just create an [issue](https://github.com/christophbrunner/unifi-api-dotnet/issues).