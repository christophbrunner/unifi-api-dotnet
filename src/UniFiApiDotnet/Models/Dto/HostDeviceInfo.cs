using System;
using System.Collections.Generic;
using UniFiApiDotnet.Abstraction;

namespace UniFiApiDotnet.Models.Dto
{
    internal class HostDeviceInfo : IHostDeviceInfo
    {
        public IEnumerable<IDevices> Devices { get; set; } = Array.Empty<IDevices>(); 
        public string HostId { get; set; } = string.Empty;
        public string HostName { get; set; } = string.Empty;
        public DateTime? UpdatedAt { get; set; } = null;
    }
}
