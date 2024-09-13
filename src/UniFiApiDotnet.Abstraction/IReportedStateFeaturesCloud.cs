namespace UniFiApiDotnet.Abstraction
{
    //todo: add documentation
    public interface IReportedStateFeaturesCloud
    {
        bool ApplicationEvents { get; set; }
        bool ApplicationEventsHttp { get; set; }
    }
}