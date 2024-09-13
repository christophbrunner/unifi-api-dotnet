namespace UniFiApiDotnet.Abstraction
{
    //todo: add documentation
    public interface IApplicationRoleAttributeDetails
    {
        bool Owned { get; set; }
        bool Required { get; set; }
        bool Supported { get; set; }
    }
}