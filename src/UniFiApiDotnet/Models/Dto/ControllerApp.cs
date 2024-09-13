using System.Diagnostics;
using UniFiApiDotnet.Abstraction;

namespace UniFiApiDotnet.Models.Dto
{
    [DebuggerDisplay("{Name,nq}")]
    internal class ControllerApp : IControllerApp
    {
        public string Name { get; set; } = string.Empty;
        public int Port { get; set; }
        public int SwaiVersion { get; set; }
        public string Type { get; set; } = string.Empty;
        public string UiCdn { get; set; } = string.Empty;
        public string UiDir { get; set; } = string.Empty;
        public string UiIndex { get; set; } = string.Empty;
        public string UiVersion { get; set; } = string.Empty;
    }
}