using UniFiApiDotnet.Abstraction;

namespace UniFiApiDotnet.Models.Dto
{
    internal class Image : IImage
    {
        public string Default { get; set; } = string.Empty;
        public string NoPadding { get; set; } = string.Empty;
        public string Topology { get; set; } = string.Empty;
    }
}
