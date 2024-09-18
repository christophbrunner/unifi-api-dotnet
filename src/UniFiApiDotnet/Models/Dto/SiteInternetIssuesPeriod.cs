using UniFiApiDotnet.Abstraction;

namespace UniFiApiDotnet.Models.Dto
{
    internal class SiteInternetIssuesPeriod : ISiteInternetIssuesPeriod
    {
        public bool? HighLatency { get; set; }
        public int Index { get; set; }
        public bool? NotReported { get; set; }
        public int? LatencyAvgMs { get; set; }
        public int? LatencyMaxMs { get; set; }
    }
}