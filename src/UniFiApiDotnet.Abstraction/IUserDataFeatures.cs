namespace UniFiApiDotnet.Abstraction
{
    //todo: add documentation
    public interface IUserDataFeatures
    {
        bool DeviceGroups { get; set; }

        /// <summary>
        /// User-specific (based on API token) the FloorPlan properties
        /// </summary>
        IUserDataFeatureFloorPlan FloorPlan { get; set; }
        bool ManageApplications { get; set; }
        bool Notifications { get; set; }
        bool Pion { get; set; }
        IUserDataFeatureWebRtc WebRtc { get; set; }
    }
}