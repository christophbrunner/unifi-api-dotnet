namespace UniFiApiDotnet.Abstraction
{
    //todo: add documentation
    public interface IApplicationRoleAttributes
    {
        IApplicationRoleAttributeDetails Access { get; set; }
        IApplicationRoleAttributeDetails Connect { get; set; }
        IApplicationRoleAttributeDetails Network { get; set; }
        IApplicationRoleAttributeDetails InnerSpace { get; set; }
        IApplicationRoleAttributeDetails Protect { get; set; }
        IApplicationRoleAttributeDetails Talk { get; set; }
    }
}
