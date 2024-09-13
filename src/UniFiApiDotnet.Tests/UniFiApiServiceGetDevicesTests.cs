using System.Text.Json.Serialization;
using System.Text.Json;
using UniFiApiDotnet.Abstraction;
using UniFiApiDotnet.Models.Dto;
using Xunit;

namespace UniFiApiDotnet.Tests;

public class UniFiApiServiceGetDevicesTests : BaseTest
{
    //[Fact]
    //public async void GetSites_RAWJson()
    //{
    //    // Arrange
    //    var uniFiApiService = GetUniFiApiService("Devices/FromUniFi.json");

    //    // Act
    //    var devices = await uniFiApiService.GetDevices();

    //    var full = new GenericApiResponse<IEnumerable<IHostDeviceInfo>>()
    //    {
    //        Data = devices
    //    };

    //    var newJsonString = JsonSerializer.Serialize(full, new JsonSerializerOptions()
    //    {
    //        PropertyNameCaseInsensitive = true,
    //        WriteIndented = true,
    //        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
    //        DictionaryKeyPolicy = JsonNamingPolicy.KebabCaseLower
    //    });


    //    await File.WriteAllTextAsync("c:\\temp\\devices.json", newJsonString);

    //    // Assert
    //}

    [Fact]
    public async void GetDevices_DeviceCount1()
    {
        // Arrange
        var uniFiApiService = GetUniFiApiService("Devices/FromUniFi.json");

        // Act
        var devices = await uniFiApiService.GetDevices();

        // Assert
        Assert.Single(devices);
    }

    [Fact]
    public async void GetDevices_HostCount3()
    {
        // Arrange
        var uniFiApiService = GetUniFiApiService("Devices/Full.json");

        // Act
        var devices = await uniFiApiService.GetDevices();

        // Assert
        Assert.Equal(3, devices.Count());
    }

    [Fact]
    public async void GetSites_SiteValues()
    {
        // Arrange
        var uniFiApiService = GetUniFiApiService("Devices/FromUniFi.json");

        // Act
        var devicesFromHosts = await uniFiApiService.GetDevices();
        var host = devicesFromHosts.First();
        var device = host.Devices.First();

        //  Assert
        // Check root values
        Assert.Equal("900A6F00301100000000074A6BA90000000007A3387E0000000063EC9853:123456789", host.HostId);
        Assert.Equal("unifi.yourdomain.com", host.HostName);
        Assert.Equal(new DateTime(2024, 7, 15, 7, 1, 13, DateTimeKind.Utc).ToLocalTime(),
            host.UpdatedAt);

        // Check Devices values

        Assert.Equal("F4E2C6C23F13", device.Id);
        Assert.Equal("192.168.1.226", device.Ip);
        Assert.Equal("F4E2C6C23F13", device.Mac);
        Assert.Equal("upToDate", device.FirmwareStatus);
        Assert.True(device.IsConsole);
        Assert.True(device.IsManaged);
        Assert.Equal("UDM SE", device.Model);
        Assert.Equal("unifi.yourdomain.com", device.Name);
        Assert.Equal("network", device.ProductLine);
        Assert.Equal("UDMPROSE", device.ShortName);
        Assert.Equal("online", device.Status);
        Assert.Equal("4.0.6", device.Version);

        // Check Devices > UiDb values
        Assert.Equal(Guid.Parse("0fd8c390-a0e8-4cb2-b93a-7b3051c83c46"), device.UiDb.Guid);
        Assert.Equal(Guid.Parse("e85485da-54c3-4906-8f19-3cef4116ff02"), device.UiDb.Id);
        Assert.Null(device.UiDb.IconId);

        // Check Devices > UiDb > Images values
        Assert.Equal("3008400039c483c496f4ad820242c447", device.UiDb.Images.Default);
        Assert.Equal("67b553529d0e523ca9dd4826076c5f3f", device.UiDb.Images.NoPadding);
        Assert.Equal("8371ecdda1f00f1636a2eefadf0d7d47", device.UiDb.Images.Topology);

    }
}