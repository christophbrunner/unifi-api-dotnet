using UniFiApiDotnet.Abstraction;

namespace UniFiApiDotnet.Models.Dto
{
    internal class UserDataFeatureWebRtc : IUserDataFeatureWebRtc
    {
        public bool IceRestart { get; set; }
        public bool MediaStreams { get; set; }
        public bool TwoWayAudio { get; set; }
    }
}