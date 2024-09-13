using UniFiApiDotnet.Abstraction;

namespace UniFiApiDotnet.Models.Dto
{
    internal class ApplicationRoleAttributeDetails : IApplicationRoleAttributeDetails
    {
        public bool Owned { get; set; }
        public bool Required { get; set; }
        public bool Supported { get; set; }

        internal static ApplicationRoleAttributeDetails NotSupported =>
            new ApplicationRoleAttributeDetails
            {
                Owned = false,
                Required = false,
                Supported = false
            };
    }
}