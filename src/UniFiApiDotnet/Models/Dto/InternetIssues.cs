using System;
using System.Collections.Generic;
using UniFiApiDotnet.Abstraction;

namespace UniFiApiDotnet.Models.Dto
{
    internal class InternetIssues : IInternetIssues
    {
        public IEnumerable<IHostInternetIssuesPeriod> Periods { get; set; } = Array.Empty<IHostInternetIssuesPeriod>();
    }
}
