using UniFiApiDotnet.Abstraction;

namespace UniFiApiDotnet.Models.Dto
{
    internal class ReportedStateFeatureUpdates :IReportedStateFeatureUpdates
    {
        public bool ApplicationSchedules { get; set; }
    }
}
