using UniFiApiDotnet.Abstraction;

namespace UniFiApiDotnet.Models.Dto
{
    internal class UserDataFeatures : IUserDataFeatures
    {
        public bool DeviceGroups { get; set; }
        public IUserDataFeatureFloorPlan FloorPlan { get; set; } = new UserDataFeatureFloorPlan();
        public bool ManageApplications { get; set; }

        public bool Notifications { get; set; }
        public bool Pion { get; set; }

        public IUserDataFeatureWebRtc WebRtc { get; set; } = new UserDataFeatureWebRtc();
    }
}