using System.Collections.Generic;

namespace UniFiApiDotnet.Abstraction
{
    /// <summary>
    /// Isp Metrics for a host
    /// </summary>
    public interface IIspMetrics
    {
        //todo: Parse the MetricType to an enum
        /// <summary>
        /// Type of the metric
        /// </summary>
        string MetricType { get; set; }

        /// <summary>
        /// Metrics Periods
        /// </summary>
        IEnumerable<IIspMetricsPeriod> Periods { get; set; }

        /// <summary>
        /// Id of the Host
        /// </summary>
        string HostId { get; set; }

        /// <summary>
        /// Id of the Site
        /// </summary>  
        string SiteId { get; set; }
    }
}
