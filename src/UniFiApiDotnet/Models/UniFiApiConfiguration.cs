namespace UniFiApiDotnet.Models
{
    internal class UniFiApiConfiguration
    {
        public string ApiKey { get; set; } = string.Empty;
        public string UserAgent { get; set; } = string.Empty;
        public string HttpClientFactoryClientName { get; set; } = string.Empty;
    }
}
