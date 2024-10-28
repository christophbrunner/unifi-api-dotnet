namespace UniFiApiDotnet.Abstraction
{
    /// <summary>
    /// ISP Metrics Period Data for a specific period
    /// </summary>
    public interface IIspMetricsPeriodData
    {
        /// <summary>
        /// Data for the WAN
        /// </summary>
        IIspMetricsPeriodDataWan Wan { get; set; }
    }
}