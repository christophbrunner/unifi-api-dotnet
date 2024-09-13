using UniFiApiDotnet.Abstraction;

namespace UniFiApiDotnet.Models.Dto
{
    internal class ApplicationRoleAttributes : IApplicationRoleAttributes
    {
        //todo: check if more available (See IUserDataPermissions)
        public IApplicationRoleAttributeDetails Access { get; set; } = ApplicationRoleAttributeDetails.NotSupported;
        public IApplicationRoleAttributeDetails Connect { get; set; } = ApplicationRoleAttributeDetails.NotSupported;
        public IApplicationRoleAttributeDetails Network { get; set; } = ApplicationRoleAttributeDetails.NotSupported;
        public IApplicationRoleAttributeDetails InnerSpace { get; set; } = ApplicationRoleAttributeDetails.NotSupported;
        public IApplicationRoleAttributeDetails Protect { get; set; } = ApplicationRoleAttributeDetails.NotSupported;
        public IApplicationRoleAttributeDetails Talk { get; set; } = ApplicationRoleAttributeDetails.NotSupported;
    }
}