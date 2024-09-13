using System;
using System.Collections.Generic;
using UniFiApiDotnet.Abstraction;

namespace UniFiApiDotnet.Models.Dto
{
    internal class InternetIssues : IInternetIssues
    {
        public IEnumerable<IInternetIssuesPeriod> Periods { get; set; } = Array.Empty<IInternetIssuesPeriod>();
    }
}
