namespace UniFiApiDotnet.Abstraction
{
    //todo: add documentation
    public interface IUserDataFeatureWebRtc
    {
        bool IceRestart { get; set; }
        bool MediaStreams { get; set; }
        bool TwoWayAudio { get; set; }
    }
}