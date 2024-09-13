using System.Collections.Generic;

namespace UniFiApiDotnet.Abstraction
{
    public interface IReportedStateUi
    {
        IEnumerable<string> CdnPublicPaths { get; set; }
        string EntryPoint { get; set; }
        IEnumerable<string> Prefetch { get; set; }
        int SwaiVersion { get; set; }

    }
}