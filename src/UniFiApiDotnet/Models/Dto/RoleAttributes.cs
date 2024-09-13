using System;
using UniFiApiDotnet.Abstraction;

namespace UniFiApiDotnet.Models.Dto
{
    internal class RoleAttributes : IRoleAttributes
    {
        public IApplicationRoleAttributes Applications { get; set; } = new ApplicationRoleAttributes();
        public string[] CandidateRoles { get; set; } = Array.Empty<string>();
        public string ConnectedState { get; set; } = string.Empty;
        public DateTime ConnectedStateLastChanged { get; set; }
    }
}
