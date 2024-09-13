using UniFiApiDotnet.Abstraction;

namespace UniFiApiDotnet
{
    public class UniFiApiBuilder : IUniFiApiBuilder
    {
        public string ApiKey { get; set; } = string.Empty;
        public string UserAgent { get; set; } = string.Empty;
        public string ConfigSectionName { get; set; } = string.Empty;
        public string HttpClientFactoryClientName { get; set; } = string.Empty;
    }
}
