using System.Text.Json.Serialization;
using System.Text.Json;
using UniFiApiDotnet.Abstraction;
using UniFiApiDotnet.Models.Dto;
using Xunit;

namespace UniFiApiDotnet.Tests;

public class UniFiApiServiceGetSitesTests : BaseTest
{
    //[Fact]
    //public async void GetSites_RAWJson()
    //{
    //    // Arrange
    //    var uniFiApiService = GetUniFiApiService("Sites/Full.json");

    //    // Act
    //    var sites = await uniFiApiService.GetSites();

    //    var full = new GenericApiResponse<IEnumerable<ISite>>()
    //    {
    //        Data = sites
    //    };

    //    var newJsonString = JsonSerializer.Serialize(full, new JsonSerializerOptions()
    //    {
    //        PropertyNameCaseInsensitive = true,
    //        WriteIndented = true,
    //        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
    //        DictionaryKeyPolicy = JsonNamingPolicy.KebabCaseLower
    //    });


    //    await File.WriteAllTextAsync("c:\\temp\\sites.json", newJsonString);

    //    // Assert
    //}

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
        Assert.Equal(5, sites.Count());
    }

    [Fact]
    public async void GetSites_SiteValues()
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
}