namespace UniFiApiDotnet.Abstraction
{
    //todo: add documentation
    public interface IReportedStateFeaturesDeviceList
    {
        bool AutoLinkDevices { get; set; }
        bool PartialUpdates { get; set; }
        bool Ucp4Events { get; set; }
    }
}