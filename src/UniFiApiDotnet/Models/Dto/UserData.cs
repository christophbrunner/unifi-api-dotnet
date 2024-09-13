using System;
using System.Collections.Generic;
using UniFiApiDotnet.Abstraction;

namespace UniFiApiDotnet.Models.Dto
{
    internal class UserData : IUserData
    {
        public string[] Apps { get; set; } = Array.Empty<string>();
        public IEnumerable<IConsoleGroupMember> ConsoleGroupMembers { get; set; } = Array.Empty<IConsoleGroupMember>();
        public string[] Controllers { get; set; } = Array.Empty<string>();
        public string Email { get; set; } = string.Empty;
        public IUserDataFeatures Features { get; set; } = new UserDataFeatures();
        public string FullName { get; set; } = string.Empty;
        public Guid LocalId { get; set; }
        public IUserDataPermissions Permissions { get; set; } = new UserDataPermissions();
        public string Role { get; set; } = string.Empty;
        public Guid RoleId { get; set; }
        public string Status { get; set; } = string.Empty;
    }
}
