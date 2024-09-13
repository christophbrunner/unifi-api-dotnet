using UniFiApiDotnet.Abstraction;

namespace UniFiApiDotnet.Models.Dto
{
    internal class ControllerFeatures : IControllerFeatures
    {
        public bool Stackable { get; set; }
    }
}
