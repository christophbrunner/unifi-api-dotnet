using System.Collections.Generic;

namespace UniFiApiDotnet.Abstraction
{
    //todo: add documentation
    public interface IInternetIssues
    {
        IEnumerable<IHostInternetIssuesPeriod> Periods { get; set; }
    }
}