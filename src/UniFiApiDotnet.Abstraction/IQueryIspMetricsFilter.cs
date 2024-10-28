using System;

namespace UniFiApiDotnet.Abstraction
{
    /// <summary>
    /// Query filter for ISP metrics
    /// </summary>
    public class QueryIspMetricsFilter
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="hostId"></param>
        /// <param name="siteId"></param>
        public QueryIspMetricsFilter(string hostId, string siteId)
        {
            HostId = hostId;
            SiteId = siteId;
        }

        /// <summary>
        /// The earliest timestamp to start retrieving data from. (optional)
        /// </summary>
        public DateTime? BeginTimestamp { get; set; }

        /// <summary>
        /// The latest timestamp up to which data will be retrieved. (optional)
        /// </summary>
        public DateTime? EndTimestamp { get; set; }

        /// <summary>
        /// The host id to filter by
        /// </summary>
        public string HostId { get; set; }

        /// <summary>
        /// The site id to filter by
        /// </summary>
        public string SiteId { get; set; }
    }
}
