using System.Net;
using UniFiApiDotnet.Abstraction;

namespace UniFiApiDotnet.Tests
{
    public abstract class BaseTest
    {
        protected IUniFiApiService GetUniFiApiService(string mockFile, HttpStatusCode statusCode = HttpStatusCode.OK,
            bool setFakeApiKey = true)
        {
            var handler = new MockHttpMessageHandler(mockFile, statusCode);
            var httpClient = new HttpClient(handler);


            IUniFiApiService service = new UniFiApiService(httpClient);

            if (setFakeApiKey)
            {
                service.SetApiKey("fakeApiKey");
            }

            return service;
        }
    }
}