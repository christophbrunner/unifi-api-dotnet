namespace UniFiApiDotnet.Abstraction
{
    //todo: add documentation
    public interface ISiteStatisticsPercentages
    {
        double TxRetry { get; set; }
        double WanUptime { get; set; }
    }
}