using System.Collections.Generic;

namespace UniFiApiDotnet.Abstraction
{
    /// <summary>
    /// Isp Metrics from the query
    /// </summary>
    public interface IIspQueryMetrics
    {
        /// <summary>
        /// Metrics for the queried host / site and period
        /// </summary>
        IEnumerable<IIspMetrics> Metrics { get; set; }
    }
}