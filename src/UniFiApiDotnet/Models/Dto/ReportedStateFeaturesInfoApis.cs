using UniFiApiDotnet.Abstraction;

namespace UniFiApiDotnet.Models.Dto
{
    public class ReportedStateFeaturesInfoApis : IReportedStateFeaturesInfoApis
    {
        public  bool FirmwareUpdate { get; set; }
    }
}