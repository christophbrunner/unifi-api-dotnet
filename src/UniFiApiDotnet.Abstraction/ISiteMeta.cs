namespace UniFiApiDotnet.Abstraction
{
    /// <summary>
    /// Site Meta data
    /// </summary>
    public interface ISiteMeta
    {
        /// <summary>
        /// Name of the site
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Description of the site
        /// </summary>
        string Desc { get; set; }

        /// <summary>
        /// Mac address of the gateway
        /// </summary>
        string GatewayMac { get; set; }

        /// <summary>
        /// Timezone ot the site (e.g. "Europe/Zurich")
        /// </summary>
        string Timezone { get; set; }
    }
}