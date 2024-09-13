using UniFiApiDotnet.Abstraction;

namespace UniFiApiDotnet.Models.Dto
{
    internal class UserDataFeatureFloorPlan : IUserDataFeatureFloorPlan
    {
        public bool CanEdit { get; set; }
        public bool CanView { get; set; }
    }
}