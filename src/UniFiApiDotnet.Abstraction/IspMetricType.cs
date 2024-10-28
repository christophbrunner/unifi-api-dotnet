namespace UniFiApiDotnet.Abstraction
{
    /// <summary>
    /// Specify whether metrics are returned using 5m or 1h intervals.
    /// </summary>
    public enum IspMetricType
    {
        /// <summary>
        /// 5 minute intervals
        /// </summary>
        Predefined5M,

        /// <summary>
        /// 1 hour intervals
        /// </summary>
        Predefined1H
    }
}