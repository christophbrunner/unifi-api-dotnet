using System;
using System.Diagnostics;
using UniFiApiDotnet.Abstraction;

namespace UniFiApiDotnet.Models.Dto
{
    [DebuggerDisplay("{Name,nq}")]
    internal class Devices : IDevices
    {
        public DateTime? AdoptionTime { get; set; }
        public string Id { get; set; } = string.Empty;
        public string Ip { get; set; } = string.Empty;
        public string FirmwareStatus { get; set; } = "Unknown";
        public bool IsConsole { get; set; }
        public bool IsManaged { get; set; }
        public string Mac { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Note { get; set; } = string.Empty;
        public string ProductLine { get; set; } = string.Empty;
        public string ShortName { get; set; } = string.Empty;
        public DateTime? StartupTime { get; set; }
        public string Status { get; set; } = string.Empty;
        public string UpdateAvailable { get; set; } = string.Empty;
        public string Version { get; set; } = string.Empty;
        public IUiDb UiDb { get; set; } = new UiDb();
    }
}
