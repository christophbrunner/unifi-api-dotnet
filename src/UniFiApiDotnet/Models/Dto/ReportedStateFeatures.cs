using UniFiApiDotnet.Abstraction;

namespace UniFiApiDotnet.Models.Dto
{
    public class ReportedStateFeatures : IReportedStateFeatures
    {
        public IReportedStateFeaturesCloud Cloud { get; set; } = new ReportedStateFeaturesCloud();
        public bool CloudBackup { get; set; }
        public IReportedStateFeaturesDeviceList DeviceList { get; set; } = new ReportedStateFeaturesDeviceList();
        public bool DirectRemoteConnection { get; set; }
        public bool HasGateway { get; set; }
        public bool HasLCM { get; set; }
        public bool HasLED { get; set; }
        public IReportedStateFeaturesInfoApis InfoApis { get; set; }   = new ReportedStateFeaturesInfoApis();
        public bool IsAutomaticFailoverAvailable { get; set; }
        public bool Mfa { get; set; }
        public bool Notifications { get; set; }
        public bool SharedTokens { get; set; }
        public bool SupportForm { get; set; }
        public bool Teleport { get; set; }
        public string TeleportState { get; set; } = string.Empty;
        public bool UidService { get; set; }
    }
}