using System;
using System.Collections.Generic;

namespace UniFiApiDotnet.Abstraction
{
    //todo: add documentation
    public interface IHostDeviceInfo
    {
        /// <summary>
        /// List of all UniFi devices
        /// </summary>
        IEnumerable<IDevices> Devices { get; set; }
        string HostId { get; set; }
        string HostName { get; set; }
        DateTime? UpdatedAt { get; set; }
    }
}
