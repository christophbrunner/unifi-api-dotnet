using UniFiApiDotnet.Abstraction;

namespace UniFiApiDotnet.Models.Dto
{
    internal class ConsoleGroupMember : IConsoleGroupMember
    {
        public string Mac { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
        public int SysId { get; set; }
        public IRoleAttributes RoleAttributes { get; set; } = new RoleAttributes();
    }
}
