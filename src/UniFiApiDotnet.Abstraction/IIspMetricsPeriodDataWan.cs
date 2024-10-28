namespace UniFiApiDotnet.Abstraction
{
    /// <summary>
    /// Isp Metrics Period Data for a specific Network (WAN)
    /// </summary>
    public interface IIspMetricsPeriodDataWan
    {
        /// <summary>
        /// Average latency in milliseconds
        /// </summary>
        int AvgLatency { get; set; }
        //todo: add documentation
        int DownloadKbps { get; set; }
        //todo: add documentation
        int Downtime { get; set; }
        //todo: add documentation
        int MaxLatency { get; set; }
        //todo: add documentation
        int PacketLoss { get; set; }
        //todo: add documentation
        int UploadKbps { get; set; }
        //todo: add documentation
        int Uptime { get; set; }
        //todo: add documentation
        string IspAsn { get; set; }
        //todo: add documentation
        string IspName { get; set; }
    }
}