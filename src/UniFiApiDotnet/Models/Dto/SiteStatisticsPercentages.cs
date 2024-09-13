using UniFiApiDotnet.Abstraction;

namespace UniFiApiDotnet.Models.Dto
{
    internal class SiteStatisticsPercentages : ISiteStatisticsPercentages
    {
        public double TxRetry { get; set; }
        public double WanUptime { get; set; }
    }
}