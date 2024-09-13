using UniFiApiDotnet.Abstraction;

namespace UniFiApiDotnet.Models.Dto
{
    internal class InternetIssuesPeriod : IInternetIssuesPeriod
    {
        public bool HighLatency { get; set; }
        public int Index { get; set; }
        public int LatencyAvgMs { get; set; }
        public int LatencyMaxMs { get; set; }
    }
}
