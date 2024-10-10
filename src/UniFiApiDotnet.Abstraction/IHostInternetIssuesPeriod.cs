namespace UniFiApiDotnet.Abstraction
{
    //todo: add documentation
    public interface IHostInternetIssuesPeriod
    {
        int Index { get; set; }

        int? Count { get; set; }

        bool? NotReported { get; set; }
    }
}