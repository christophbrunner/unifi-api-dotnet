namespace UniFiApiDotnet.Abstraction
{
    //todo: add documentation
    public interface IInternetIssuesPeriod
    {
        bool HighLatency { get; set; }
        int Index { get; set; }

        /// <summary>
        /// Average latency in milliseconds
        /// </summary>
        int LatencyAvgMs { get; set; }

        /// <summary>
        /// Maximal latency in milliseconds
        /// </summary>
        int LatencyMaxMs { get; set; }
    }
}