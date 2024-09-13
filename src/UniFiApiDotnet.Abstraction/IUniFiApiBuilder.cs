namespace UniFiApiDotnet.Abstraction
{
    public interface IUniFiApiBuilder
    {
        /// <summary>
        /// Personal API key to be used for the authentication
        /// </summary>
        /// <remarks>The API key can be created in the UniFi Site Manager &gt; API (https://unifi.ui.com/api)</remarks>
        /// <see href="https://unifi.ui.com/api">Site Manager &amp;gt; API</see>
        string ApiKey { get; set; }

        /// <summary>
        /// UserAgent to be used for the requests.
        /// </summary>
        /// <remarks>Not relevant for the calls</remarks>
        string UserAgent { get; set; }

        /// <summary>
        /// Section name in the configuration file to be used for the configuration.
        /// By default, it is `UniFiApi`
        /// </summary>
        /// <code>
        /// {
        ///     "UniFiApi": {
        ///         "ApiKey": "[your_api_key]"
        ///     }
        /// }
        /// </code>
        string ConfigSectionName { get; set; }

        /// <summary>
        /// Name of the registered HttpClient in the ServiceCollection to be used for the requests.
        /// Default is `UniFiApi`
        /// </summary>
        string HttpClientFactoryClientName { get; set; }
    }
}
