using System.Net;

namespace UniFiApiDotnet.Tests
{
    public class MockHttpMessageHandler : HttpMessageHandler
    {

        private readonly string _mockFile;
        private readonly HttpStatusCode _statusCode;

        public MockHttpMessageHandler(string mockFile, HttpStatusCode statusCode)
        {
            _mockFile = mockFile;
            _statusCode = statusCode;
        }

        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            
                string content = string.IsNullOrEmpty(_mockFile)
                    ? string.Empty
                    : File.ReadAllText($"TestData/{_mockFile}");
            
        
                var response = new HttpResponseMessage(_statusCode)
                {
                    Content = new StringContent(content)
                };

                return Task.FromResult(response);
            }
    }
}
