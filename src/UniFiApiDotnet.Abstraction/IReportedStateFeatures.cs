namespace UniFiApiDotnet.Abstraction
{
    //todo: add documentation
    public interface IReportedStateFeatures
    {
        IReportedStateFeaturesCloud Cloud { get; set; }
        bool CloudBackup { get; set; }
        IReportedStateFeaturesDeviceList DeviceList { get; set; }
        bool DirectRemoteConnection { get; set; }
        bool HasGateway { get; set; }
        bool HasLCM { get; set; }
        bool HasLED { get; set; }
        IReportedStateFeaturesInfoApis InfoApis { get; set; }
        bool IsAutomaticFailoverAvailable { get; set; }
        bool Mfa { get; set; }
        bool Notifications { get; set; }
        bool SharedTokens { get; set; }
        bool SupportForm { get; set; }
        bool Teleport { get; set; }
        string TeleportState { get; set; }
        bool UidService { get; set; }
    }
}