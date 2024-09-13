using System;
using System.Diagnostics;
using UniFiApiDotnet.Abstraction;

namespace UniFiApiDotnet.Models.Dto
{
    [DebuggerDisplay("{ReportedState.Name,nq}")]
    internal class Host : IHost
    {
        public Guid HardwareId { get; set; }

        public string Id { get; set; } = string.Empty;

        public string IpAddress { get; set; } = string.Empty;

        public bool IsBlocked { get; set; } = false;

        public DateTime? LastConnectionStateChange { get; set; }

        public DateTime? LatestBackupTime { get; set; }

        public bool Owner { get; set; }

        public DateTime? RegistrationTime { get; set; }

        public IReportedState ReportedState { get; set; } = new ReportedState();

        public string Type { get; set; } = "unknown";

        public IUserData UserData { get; set; } = new UserData();
    }
}