using System;

namespace UniFiApiDotnet.Abstraction
{
    //todo: add documentation
    public interface IHost
    {
        Guid HardwareId { get; set; }
        string Id { get; set; }
        string IpAddress { get; set; }
        bool IsBlocked { get; set; }
        DateTime? LastConnectionStateChange { get; set; }
        DateTime? LatestBackupTime { get; set; }
        bool Owner { get; set; }
        DateTime? RegistrationTime { get; set; }
        IReportedState ReportedState { get; set; }
        string Type { get; set; }
        public IUserData UserData { get; set; }
    }
}