using UniFiApiDotnet.Abstraction;

namespace UniFiApiDotnet.Models.Dto
{
    public class ReportedStateFeaturesCloud : IReportedStateFeaturesCloud
    {
        public bool ApplicationEvents { get; set; }
        public bool ApplicationEventsHttp { get; set; }
    }
}