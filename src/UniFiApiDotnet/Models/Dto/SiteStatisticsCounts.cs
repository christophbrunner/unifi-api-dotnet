using UniFiApiDotnet.Abstraction;

namespace UniFiApiDotnet.Models.Dto
{
    internal class SiteStatisticsCounts : ISiteStatisticsCounts
    {
        public int CriticalNotification { get; set; }
        public int GatewayDevice { get; set; }
        public int GuestClient { get; set; }
        public int LanConfiguration { get; set; }
        public int OfflineDevice { get; set; }
        public int OfflineGatewayDevice { get; set; }
        public int OfflineWifiDevice { get; set; }
        public int OfflineWiredDevice { get; set; }
        public int PendingUpdateDevice { get; set; }
        public int TotalDevice { get; set; }
        public int WanConfiguration { get; set; }
        public int WifiClient { get; set; }
        public int WifiConfiguration { get; set; }
        public int WifiDevice { get; set; }
        public int WiredClient { get; set; }
        public int WiredDevice { get; set; }
    }
}