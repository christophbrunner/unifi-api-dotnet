using System.Text.Json;
using System.Text.Json.Serialization;
using UniFiApiDotnet.Abstraction;
using UniFiApiDotnet.Models.Dto;
using Xunit;

namespace UniFiApiDotnet.Tests;

public class UniFiApiServiceGetHostsTests : BaseTest
{
    //[Fact]
    //public async void GetHosts_RAWJson()
    //{
    //    // Arrange
    //    var uniFiApiService = GetUniFiApiService("Hosts/Full.json");

    //    // Act
    //    var hosts = await uniFiApiService.GetHosts();

    //    var full = new GenericApiResponse<IEnumerable<IHost>>()
    //    {
    //        Data = hosts
    //    };

    //    var newJsonString = JsonSerializer.Serialize(full, new JsonSerializerOptions()
    //    {
    //        PropertyNameCaseInsensitive = true,
    //        WriteIndented = true,
    //        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull, DictionaryKeyPolicy = JsonNamingPolicy.KebabCaseLower
    //    });

   


    //    await File.WriteAllTextAsync("c:\\temp\\hosts.json", newJsonString);

    //    // Assert
    //}

    [Fact]
    public async void GetHosts_HostCount1()
    {
        // Arrange
        var uniFiApiService = GetUniFiApiService("Hosts/FromUniFi.json");

        // Act
        var hosts = await uniFiApiService.GetHosts();

        // Assert
        Assert.Single(hosts);
    }

    [Fact]
    public async void GetHosts_HostCountFull()
    {
        // Arrange
        var uniFiApiService = GetUniFiApiService("Hosts/Full.json");

        // Act
        var hosts = await uniFiApiService.GetHosts();

        // Assert
        Assert.Equal(4,hosts.Count());
    }

    [Fact]
    public async void GetHosts_HostValues()
    {
        // Arrange
        var uniFiApiService = GetUniFiApiService("Hosts/FromUniFi.json");

        // Act
        var hosts = await uniFiApiService.GetHosts();
var host = hosts.First();

        // Assert
        // Check root values
        Assert.Equal(Guid.Parse("eae0f123-0000-5111-b111-f833f56eade5"), host.HardwareId);
        Assert.Equal("900A6F00301100000000074A6BA90000000007A3387E0000000063EC9853:123456789", host.Id);
        Assert.Equal("192.168.220.114", host.IpAddress);
        Assert.False(host.IsBlocked);
        Assert.Equal(new DateTime(2024, 6, 23, 3, 59, 52, DateTimeKind.Utc).ToLocalTime(),
            host.LastConnectionStateChange);
        Assert.Equal(new DateTime(2024, 6, 22, 11, 55, 10, DateTimeKind.Utc).ToLocalTime(), host.LatestBackupTime);
        Assert.True(host.Owner);
        Assert.Equal(new DateTime(2024, 4, 17, 7, 27, 14, DateTimeKind.Utc).ToLocalTime(), host.RegistrationTime);
        Assert.Equal("console", host.Type);

        // Check reportedState values
        Assert.Equal(Guid.Parse("c2705509-58a5-40c9-8b2e-d29c8574ff08"), host.ReportedState.AnonId);
        Assert.Equal("900A6F00301100000000074A6BA90000000007A3387E0000000063EC9853:123456789",
            host.ReportedState.ControllerUuid);
        Assert.Equal(840, host.ReportedState.Country);
        //todo: Check reportedState.deviceErrorCode value (null)
        Assert.Equal("setup", host.ReportedState.DeviceState);
        Assert.Equal(new DateTime(2024, 6, 19, 13, 45, 49, DateTimeKind.Utc).ToLocalTime(),
            host.ReportedState.DeviceStateLastChanged);
        Assert.Equal("f4e2c6c23f1307bc5608082112aa0651cbf10.id.ui.direct", host.ReportedState.DirectConnectDomain);
        Assert.Equal(59948, host.ReportedState.HostType);
        Assert.Equal("unifi.yourdomain.com", host.ReportedState.HostName);
        Assert.Equal("192.168.1.226", host.ReportedState.Ip);
        Assert.Equal(6, host.ReportedState.IpAddrs.Count());
        Assert.Equal("fe80::f6e2:c6ff:fec2:3f15", host.ReportedState.IpAddrs.First());
        Assert.False(host.ReportedState.IsStacked);
        Assert.Equal("F4E1C6C11F00", host.ReportedState.Mac);
        Assert.Equal(443, host.ReportedState.ManagementPort);
        Assert.Equal("unifi.yourdomain.com", host.ReportedState.Name);
        Assert.Equal("beta", host.ReportedState.ReleaseChannel);
        Assert.Equal("connected", host.ReportedState.State);
        Assert.Equal("Europe/Riga", host.ReportedState.Timezone);
        Assert.Equal("4.0.180", host.ReportedState.Version);

        // Check reportedState.Apps values
        Assert.Single( host.ReportedState.Apps);

        var app = host.ReportedState.Apps.First();

        Assert.Equal("READY", app.ControllerStatus);
        Assert.Equal("users", app.Name);
        Assert.Equal(9080, app.Port);
        Assert.Equal(2, app.SwaiVersion);
        Assert.Equal("app", app.Type);
        Assert.Equal("1.8.42+3695", app.Version);

        // Check reportedState.AvailableChannels values
        Assert.Equal(3, host.ReportedState.AvailableChannels.Count());
        Assert.Equal("release", host.ReportedState.AvailableChannels.First());

        // Check reportedState.ConsolesOnSameLocalNetwork values
        Assert.Empty(host.ReportedState.ConsolesOnSameLocalNetwork);

        // Check reportedState.Controllers values
        Assert.Equal(6, host.ReportedState.Controllers.Count());

        var controller1 = host.ReportedState.Controllers.First();

        Assert.True(controller1.Abridged);
        Assert.Equal("READY", controller1.ControllerStatus);
        Assert.True(controller1.InitialDeviceListSynced);
        Assert.Equal("installed", controller1.InstallState);
        Assert.True(controller1.IsConfigured);
        Assert.True(controller1.IsInstalled);
        Assert.True(controller1.IsRunning);
        Assert.Equal("network", controller1.Name);
        Assert.Equal(8081, controller1.Port);
        Assert.Equal("beta", controller1.ReleaseChannel);
        Assert.True(controller1.Required);
        Assert.Equal("active", controller1.State);
        Assert.Equal("ok", controller1.Status);
        Assert.Equal("", controller1.StatusMessage);
        Assert.Equal(3, controller1.SwaiVersion);
        Assert.Equal("controller", controller1.Type);
        Assert.Equal("8.4.20.0", controller1.UiVersion);
        Assert.True(controller1.Updatable);
        Assert.Equal("8.4.20", controller1.Version);
        //todo:  Check reportedState.controllers[0].updateAvailable. values
        //todo: Check reportedState.controllers[0].features. values
        //todo: Check reportedState.controllers[0].updateAvailable. values

        var controller2 = host.ReportedState.Controllers.Skip(1).First();
        Assert.Equal("protect", controller2.Name);

        //todo: Check reportedState.controllers[1].features. values

        // Check reportedState.Features values
        Assert.True(host.ReportedState.Features.CloudBackup);
        Assert.True(host.ReportedState.Features.DirectRemoteConnection);
        Assert.True(host.ReportedState.Features.HasGateway);
        Assert.True(host.ReportedState.Features.HasLCM);
        Assert.False(host.ReportedState.Features.HasLED);
        Assert.False(host.ReportedState.Features.IsAutomaticFailoverAvailable);
        Assert.True(host.ReportedState.Features.Mfa);
        Assert.True(host.ReportedState.Features.Notifications);
        Assert.True(host.ReportedState.Features.SharedTokens);
        Assert.False(host.ReportedState.Features.Teleport);
        Assert.Equal("DISABLED", host.ReportedState.Features.TeleportState);
        Assert.True(host.ReportedState.Features.UidService);

        // Check reportedState.Features.Cloud values
        Assert.True(host.ReportedState.Features.Cloud.ApplicationEvents);
        Assert.True(host.ReportedState.Features.Cloud.ApplicationEventsHttp);

        // Check reportedState.Features.DeviceList values
        Assert.True(host.ReportedState.Features.DeviceList.AutoLinkDevices);
        Assert.True(host.ReportedState.Features.DeviceList.PartialUpdates);
        Assert.True(host.ReportedState.Features.DeviceList.Ucp4Events);

        // Check reportedState.Features.InfoApis values
        Assert.True(host.ReportedState.Features.InfoApis.FirmwareUpdate);

        //todo: Check reportedState.features values
        //todo: Check reportedState.firmwareUpdate values
        //todo: Check reportedState.hardware values
        //todo: Check reportedState.internetIssues5min values
        //todo: Check reportedState.ipAddrs values

        // Check reportedState.location values
        Assert.Equal(56.9496, host.ReportedState.Location.Lat);
        Assert.Equal(24.0978, host.ReportedState.Location.Long);
        Assert.Equal(200, host.ReportedState.Location.Radius);
        Assert.Equal("-----------", host.ReportedState.Location.Text);


        //todo: Check reportedState.uidb values
        //todo: Check reportedState.unadoptedUnifiOSDevices values

        //todo: Check userData values
        Assert.Equal("unifi@test-ui.com", host.UserData.Email);
        Assert.Equal("UniFi User", host.UserData.FullName);
        Assert.Equal(Guid.Parse("f537f425-945d-49bf-8b88-e7ed6469b2bb"), host.UserData.LocalId);
        Assert.Equal("owner", host.UserData.Role);
        Assert.Equal(Guid.Parse("eb0ac6f9-21d7-4121-98e5-078ae8bacd96"), host.UserData.RoleId);
        Assert.Equal("ACTIVE", host.UserData.Status);

        //todo: Check userData.apps values
        //todo: Check userData.consoleGroupMembers values
        //todo: Check userData.controllers values
        //todo: Check userData.features values
        //todo: Check userData.permissions values
    }
}