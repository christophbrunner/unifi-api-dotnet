using System;
using System.Collections.Generic;
using System.Diagnostics;
using UniFiApiDotnet.Abstraction;

namespace UniFiApiDotnet.Models.Dto
{
    [DebuggerDisplay("{Model,nq}")]

    internal class UnAdoptedDevice : IUnAdoptedDevice
    {
        public IEnumerable<IUnAdoptedDevicesAddress> Addresses { get; set; } = Array.Empty<IUnAdoptedDevicesAddress>();
        public Guid IconId { get; set; }
        public string Model { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public int TotalCount { get; set; }
    }
}
