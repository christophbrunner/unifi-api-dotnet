using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using UniFiApiDotnet.Abstraction;

namespace UniFiApiDotnet.Models.Dto
{
    internal class ReportedState : IReportedState
    {
        public Guid AnonId { get; set; } = Guid.Empty;
        public IEnumerable<IApp> Apps { get; set; } = Array.Empty<IApp>();
        public IAutoUpdate? AutoUpdate { get; set; }
        public string[] AvailableChannels { get; set; } = Array.Empty<string>();

        public IEnumerable<IController> Controllers { get; set; } = Array.Empty<IController>();
        public string[] ConsolesOnSameLocalNetwork { get; set; } = Array.Empty<string>();

        [JsonPropertyName("controller_uuid")]
        public string ControllerUuid { get; set; } = string.Empty;

        public int Country { get; set; }
        public string DeviceState { get; set; } = "unknown";
        public DateTime? DeviceStateLastChanged { get; set; }
        public string DirectConnectDomain { get; set; } = string.Empty;
        public IReportedStateFeatures Features { get; set; } = new ReportedStateFeatures();
        public IReportedStateFirmwareUpdate FirmwareUpdate { get; set; } = new ReportedStateFirmwareUpdate();
        public IReportedStateHardware Hardware { get; set; } = new ReportedStateHardware();

        [JsonPropertyName("host_type")] 
        public int HostType { get; set; }

        public string HostName { get; set; } = string.Empty;
        public string Ip { get; set; } = string.Empty;
        public IEnumerable<string> IpAddrs { get; set; } = Array.Empty<string>();
        public bool IsStacked { get; set; }
        public bool IsUbiOsMigration { get; set; }
        public ILocation Location { get; set; } = new Location();
        public string Mac { get; set; } = string.Empty;

        [JsonPropertyName("mgmt_port")] 
        public int ManagementPort { get; set; }

        public string Name { get; set; } = string.Empty;
        public string ReleaseChannel { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string Timezone { get; set; } = string.Empty;
        public IUiDb UiDb { get; set; } = new UiDb();
        public IInternetIssues InternetIssues5min { get; set; } = new InternetIssues();
        public string Version { get; set; } = string.Empty;

        [JsonPropertyName("override_inform_host")]
        public bool OverrideInformHost { get; set; }
    }
}