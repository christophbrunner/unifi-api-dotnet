namespace UniFiApiDotnet.Abstraction
{
    public interface ISiteStatisticsIspInfo
    {
        /// <summary>
        /// Name of the ISP
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Organization of the ISP
        /// </summary>
        string Organization { get; set; }
    }
}