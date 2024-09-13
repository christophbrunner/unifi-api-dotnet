using Xunit;

namespace UniFiApiDotnet.Tests;

public class UniFiApiServiceGetSitesTests : BaseTest
{
    [Fact]
    public async void GetSites_HostCount1()
    {
        // Arrange
        var uniFiApiService = GetUniFiApiService("Sites/FromUniFi.json");

        // Act
        var sites = await uniFiApiService.GetSites();

        // Assert
        Assert.Single(sites);
    }

    [Fact]
    public async void GetSites_HostCount5()
    {
        // Arrange
        var uniFiApiService = GetUniFiApiService("Sites/Full.json");

        // Act
        var sites = await uniFiApiService.GetSites();

        // Assert
        Assert.Equal(4, sites.Count());
    }

    [Fact]
    public async void GetSites_SiteValues_Demo()
    {
        // Arrange
        var uniFiApiService = GetUniFiApiService("Sites/FromUniFi.json");

        // Act
        var sites = await uniFiApiService.GetSites();
        var site = sites.First();

        //  Assert
        // Check root values
         Assert.Equal("900A6F00301100000000074A6BA90000000007A3387E0000000063EC9853:123456789", site.HostId);
         Assert.Equal("661900ae6aec8f548d49fd54", site.SiteId);
         Assert.Equal("admin", site.Permission);
         Assert.Equal(new DateTime(2024, 6, 27, 13, 9, 46, DateTimeKind.Utc),
             site.SubscriptionEndTime);
        Assert.True(site.IsOwner);

        // Check Meta values
        Assert.Equal("Default", site.Meta.Desc);
        Assert.Equal("f4:e2:c6:c2:3f:13", site.Meta.GatewayMac);
        Assert.Equal("default", site.Meta.Name);
        Assert.Equal("Europe/Riga", site.Meta.Timezone);

        // Check Statistics > Counts values
        Assert.Equal(0, site.Statistics.Counts.CriticalNotification);
        Assert.Equal(1, site.Statistics.Counts.GatewayDevice);
        Assert.Equal(0, site.Statistics.Counts.GuestClient);
        Assert.Equal(2, site.Statistics.Counts.LanConfiguration);
        Assert.Equal(0, site.Statistics.Counts.OfflineDevice);
        Assert.Equal(0, site.Statistics.Counts.OfflineGatewayDevice);
        Assert.Equal(0, site.Statistics.Counts.OfflineWifiDevice);
        Assert.Equal(0, site.Statistics.Counts.OfflineWiredDevice);
        Assert.Equal(0, site.Statistics.Counts.PendingUpdateDevice);
        Assert.Equal(1, site.Statistics.Counts.TotalDevice);
        Assert.Equal(2, site.Statistics.Counts.WanConfiguration);
        Assert.Equal(0, site.Statistics.Counts.WifiClient);
        Assert.Equal(0, site.Statistics.Counts.WifiConfiguration);
        Assert.Equal(0, site.Statistics.Counts.WifiDevice);
        Assert.Equal(1, site.Statistics.Counts.WiredClient);
        Assert.Equal(0, site.Statistics.Counts.WiredDevice);

        // Check Statistics > InternetIssues values
        Assert.Equal(3, site.Statistics.InternetIssues.Count());
        var period = site.Statistics.InternetIssues.First();
        Assert.True(period.HighLatency);
        Assert.Equal(5731624, period.Index);
        Assert.Equal(23, period.LatencyAvgMs);
        Assert.Equal(35, period.LatencyMaxMs);

        // Check Statistics > IspInfo values
        Assert.Equal("TET", site.Statistics.IspInfo.Name);
        Assert.Equal("SIA Tet", site.Statistics.IspInfo.Organization);

        // Check Statistics > Percentages values
        Assert.Equal(2.03, site.Statistics.Percentages.TxRetry);
        Assert.Equal(99.86, site.Statistics.Percentages.WanUptime);

    }

    [Fact]
    public async void GetSites_SiteValues_Full()
    {
        // Arrange
        var uniFiApiService = GetUniFiApiService("Sites/Full.json");

        // Act
        var sites = await uniFiApiService.GetSites();
        var site = sites.First();

        //  Assert
        // Check root values
        Assert.Equal("000000000000000000000000000000000000000000000000000000000000:000000000", site.HostId);
        Assert.Equal("000000000000000000000000", site.SiteId);
        Assert.Equal("admin", site.Permission);
        Assert.Equal(new DateTime(2024, 1, 1, 1, 0, 0, DateTimeKind.Utc),
            site.SubscriptionEndTime);
        Assert.True(site.IsOwner);

        // Check Meta values
        Assert.Equal("Default", site.Meta.Desc);
        Assert.Equal("d0:21:00:00:00:00", site.Meta.GatewayMac);
        Assert.Equal("default", site.Meta.Name);
        Assert.Equal("Europe/Zurich", site.Meta.Timezone);

        // Check Statistics > Counts values
        Assert.Equal(1, site.Statistics.Counts.CriticalNotification);
        Assert.Equal(2, site.Statistics.Counts.GatewayDevice);
        Assert.Equal(3, site.Statistics.Counts.GuestClient);
        Assert.Equal(4, site.Statistics.Counts.LanConfiguration);
        Assert.Equal(5, site.Statistics.Counts.OfflineDevice);
        Assert.Equal(6, site.Statistics.Counts.OfflineGatewayDevice);
        Assert.Equal(7, site.Statistics.Counts.OfflineWifiDevice);
        Assert.Equal(8, site.Statistics.Counts.OfflineWiredDevice);
        Assert.Equal(9, site.Statistics.Counts.PendingUpdateDevice);
        Assert.Equal(10, site.Statistics.Counts.TotalDevice);
        Assert.Equal(11, site.Statistics.Counts.WanConfiguration);
        Assert.Equal(12, site.Statistics.Counts.WifiClient);
        Assert.Equal(13, site.Statistics.Counts.WifiConfiguration);
        Assert.Equal(14, site.Statistics.Counts.WifiDevice);
        Assert.Equal(15, site.Statistics.Counts.WiredClient);
        Assert.Equal(16, site.Statistics.Counts.WiredDevice);

        // Check Statistics > InternetIssues values
        Assert.Equal(3, site.Statistics.InternetIssues.Count());
        var period = site.Statistics.InternetIssues.First();
        Assert.True(period.HighLatency);
        Assert.Equal(5731624, period.Index);
        Assert.Equal(23, period.LatencyAvgMs);
        Assert.Equal(35, period.LatencyMaxMs);

        // Check Statistics > IspInfo values
        Assert.Equal("Swisscom", site.Statistics.IspInfo.Name);
        Assert.Equal("Bluewin", site.Statistics.IspInfo.Organization);

        // Check Statistics > Percentages values
        Assert.Equal(3.04, site.Statistics.Percentages.TxRetry);
        Assert.Equal(100, site.Statistics.Percentages.WanUptime);

    }
}