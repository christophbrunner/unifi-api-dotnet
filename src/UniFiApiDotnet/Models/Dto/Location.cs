using UniFiApiDotnet.Abstraction;

namespace UniFiApiDotnet.Models.Dto
{
    internal class Location : ILocation
    {
        public double Lat { get; set; }
        public double Long { get; set; }
        public int Radius { get; set; }
        public string Text { get; set; } = string.Empty;
    }
}
