using System;
using System.Diagnostics;
using System.Text.Json.Serialization;
using UniFiApiDotnet.Abstraction;

namespace UniFiApiDotnet.Models.Dto
{
    [DebuggerDisplay("{Name,nq}")]

    internal class ReportedStateHardware : IReportedStateHardware
    {
        public string Bom { get; set; } = string.Empty;

        [JsonPropertyName("cpu.id")]
        public string CpuId { get; set; } = string.Empty;
        public string DebianCodename { get; set; } = string.Empty;
        public string FirmwareVersion { get; set; } = string.Empty;
        public int HwRev { get; set; }
        public string Mac { get; set; } = string.Empty;
        public bool IsUbiOs { get; set; }
        public string Name { get; set; } = string.Empty;
        public string QrId { get; set; } = string.Empty;
        public string Reboot { get; set; } = string.Empty;
        public string SerialNo { get; set; } = string.Empty;
        public string ShortName { get; set; } = string.Empty;
        public string Subtype { get; set; } = string.Empty;
        public int SysId { get; set; }
        public string Upgrade { get; set; } = string.Empty;
        public Guid Uuid { get; set; }
    }
}
