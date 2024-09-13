using System;
using System.Collections.Generic;

namespace UniFiApiDotnet.Abstraction
{
    //todo: add documentation
    public interface IUserData
    {
        string[] Apps { get; set; }
        IEnumerable<IConsoleGroupMember> ConsoleGroupMembers { get; set; }
        string[] Controllers { get; set; }

        /// <summary>
        /// Email of the user (based on the API-Key)
        /// </summary>
        string Email { get; set; }

        /// <summary>
        /// Full name of the user (based on the API-Key)
        /// </summary>
        string FullName { get; set; }

        IUserDataFeatures Features { get; set; }

        Guid LocalId { get; set; }

        /// <summary>
        /// Permissions of the user (based on the API-Key)
        /// </summary>
        IUserDataPermissions Permissions { get; set; }

        /// <summary>
        /// Role of the user on the host (based on the API-Key)
        /// </summary>
        string Role { get; set; }

        /// <summary>
        /// RoleId of the user on the host (based on the API-Key)
        /// </summary>
        Guid RoleId { get; set; }

        /// <summary>
        /// Status of the user on the host (based on the API-Key)
        /// </summary>
        string Status { get; set; }
    }
}
