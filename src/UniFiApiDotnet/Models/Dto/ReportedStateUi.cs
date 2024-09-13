using System;
using System.Collections.Generic;
using UniFiApiDotnet.Abstraction;

namespace UniFiApiDotnet.Models.Dto
{
    internal class ReportedStateUi : IReportedStateUi
    {
        public IEnumerable<string> CdnPublicPaths { get; set; } = Array.Empty<string>();
        public string EntryPoint { get; set; } = string.Empty;
        public IEnumerable<string> Prefetch { get; set; } = Array.Empty<string>();
        public int SwaiVersion { get; set; }
    }
}
