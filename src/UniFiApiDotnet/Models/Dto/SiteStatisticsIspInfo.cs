using UniFiApiDotnet.Abstraction;

namespace UniFiApiDotnet.Models.Dto
{
    internal class SiteStatisticsIspInfo : ISiteStatisticsIspInfo
    {
        public string Name { get; set; } = string.Empty;
        public string Organization { get; set; } = string.Empty;
    }
}