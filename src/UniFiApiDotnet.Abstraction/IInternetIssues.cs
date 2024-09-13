using System.Collections.Generic;

namespace UniFiApiDotnet.Abstraction
{
    //todo: add documentation
    public interface IInternetIssues
    {
        IEnumerable<IInternetIssuesPeriod> Periods { get; set; }
    }
}