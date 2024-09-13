namespace UniFiApiDotnet.Abstraction
{
    //todo: add documentation
    public interface IConsoleGroupMember
    {
        string Mac { get; set; }
        string Role { get; set; }
        int SysId { get; set; }
        IRoleAttributes RoleAttributes { get; set; }
    }
}