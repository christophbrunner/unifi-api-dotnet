using UniFiApiDotnet.Abstraction;

namespace UniFiApiDotnet.Models.Dto
{
    public class ReportedStateFeaturesDeviceList : IReportedStateFeaturesDeviceList
    {
        public bool AutoLinkDevices { get; set; }
        public bool PartialUpdates { get; set; }
        public bool Ucp4Events { get; set; }
    }
}