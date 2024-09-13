using System.Diagnostics;
using UniFiApiDotnet.Abstraction;

namespace UniFiApiDotnet.Models.Dto
{
    [DebuggerDisplay("{Ip,nq}")]
    internal class UnAdoptedDevicesAddress : IUnAdoptedDevicesAddress
    {
        public string Ip { get; set; } = string.Empty;
        public string Mac { get; set; } = string.Empty; 
    }
}
