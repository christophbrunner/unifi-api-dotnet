namespace UniFiApiDotnet.Abstraction
{
    //todo: add documentation
    public interface ISiteInternetIssuesPeriod
    {
        bool? HighLatency { get; set; }
        int Index { get; set; }

        bool? NotReported { get; set; }

        /// <summary>
        /// Average latency in milliseconds
        /// </summary>
        int? LatencyAvgMs { get; set; }

        /// <summary>
        /// Maximal latency in milliseconds
        /// </summary>
        int? LatencyMaxMs { get; set; }
    }
}