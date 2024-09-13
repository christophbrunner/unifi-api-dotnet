namespace UniFiApiDotnet.Abstraction
{
    //todo: add documentation
    public interface IUserDataPermissions
    {
        string[] AccessManagement { get; set; }
        string[] CalculusManagement { get; set; }
        string[] ConnectManagement { get; set; }
        string[] DriveManagement { get; set; }
        string[] OlympusManagement { get; set; }
        string[] NetworkManagement { get; set; }
        string[] InnerSpaceManagement { get; set; }
        string[] LedManagement { get; set; }
        string[] ProtectManagement { get; set; }
        string[] TalkManagement { get; set; }

        string[] SystemManagementUser { get; set; }
        string[] SystemManagementLocation { get; set; }
    }
}