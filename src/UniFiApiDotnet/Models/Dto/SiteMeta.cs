using UniFiApiDotnet.Abstraction;

namespace UniFiApiDotnet.Models.Dto
{
    internal class SiteMeta : ISiteMeta
    {
        public string Desc { get; set; } = string.Empty;
        public string GatewayMac { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Timezone { get; set; } = string.Empty;
    }
}