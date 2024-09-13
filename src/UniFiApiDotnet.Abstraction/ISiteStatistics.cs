using System.Collections.Generic;

namespace UniFiApiDotnet.Abstraction
{
    //todo: add documentation
    public interface ISiteStatistics
    {
        ISiteStatisticsCounts Counts { get; set; }
        IEnumerable<IInternetIssuesPeriod> InternetIssues { get; set; }

        /// <summary>
        /// Information about the ISP (from the active WAN connection)
        /// </summary>
        ISiteStatisticsIspInfo IspInfo { get; set; }

        ISiteStatisticsPercentages Percentages { get; set; }
    }
}