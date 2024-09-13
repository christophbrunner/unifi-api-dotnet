using System.Diagnostics;
using UniFiApiDotnet.Abstraction;

namespace UniFiApiDotnet.Models.Dto
{
    [DebuggerDisplay("{Name,nq}")]
    internal class App : IApp
    {
        public string ControllerStatus { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public int Port { get; set; }
        public int SwaiVersion { get; set; }
        public string Type { get; set; } = string.Empty;
        public string Version { get; set; } = string.Empty;
    }
}
