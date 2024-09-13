namespace UniFiApiDotnet.Abstraction
{
    //todo: add documentation
    public interface ISiteMeta
    {
        string Desc { get; set; }
        string GatewayMac { get; set; }
        string Name { get; set; }

        /// <summary>
        /// Timezone ot the site (e.g. "Europe/Zurich")
        /// </summary>
        string Timezone { get; set; }
    }
}