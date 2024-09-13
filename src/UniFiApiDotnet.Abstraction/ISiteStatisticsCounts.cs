namespace UniFiApiDotnet.Abstraction
{
    //todo: add documentation
    public interface ISiteStatisticsCounts
    {
        int CriticalNotification { get; set; }
        int GatewayDevice { get; set; }
        int GuestClient { get; set; }
        int LanConfiguration { get; set; }
        int OfflineDevice { get; set; }
        int OfflineGatewayDevice { get; set; }
        int OfflineWifiDevice { get; set; }
        int OfflineWiredDevice { get; set; }
        int PendingUpdateDevice { get; set; }
        int TotalDevice { get; set; }
        int WanConfiguration { get; set; }
        int WifiClient { get; set; }
        int WifiConfiguration { get; set; }
        int WifiDevice { get; set; }
        int WiredClient { get; set; }
        int WiredDevice { get; set; }
    }
}