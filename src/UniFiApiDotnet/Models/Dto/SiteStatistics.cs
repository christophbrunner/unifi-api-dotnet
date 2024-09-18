using System;
using System.Collections.Generic;
using UniFiApiDotnet.Abstraction;

namespace UniFiApiDotnet.Models.Dto
{
    internal class SiteStatistics : ISiteStatistics
    {
        public ISiteStatisticsCounts Counts { get; set; } = new SiteStatisticsCounts();
        public IEnumerable<ISiteInternetIssuesPeriod> InternetIssues { get; set; } = Array.Empty<ISiteInternetIssuesPeriod>();
        public ISiteStatisticsIspInfo IspInfo { get; set; } = new SiteStatisticsIspInfo();
        public ISiteStatisticsPercentages Percentages { get; set; } = new SiteStatisticsPercentages();
    }
}