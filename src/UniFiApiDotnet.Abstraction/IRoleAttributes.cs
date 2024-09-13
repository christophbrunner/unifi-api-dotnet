using System;

namespace UniFiApiDotnet.Abstraction
{
    //todo: add documentation
    public interface IRoleAttributes
    {
        IApplicationRoleAttributes Applications { get; set; }
        string[] CandidateRoles { get; set; }
        string ConnectedState { get; set; }
        DateTime ConnectedStateLastChanged { get; set; }
    }
}