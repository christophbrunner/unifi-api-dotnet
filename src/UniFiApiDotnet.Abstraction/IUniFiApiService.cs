using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace UniFiApiDotnet.Abstraction
{
    /// <summary>
    /// Interface for UniFi API Service.
    /// </summary>
    public interface IUniFiApiService : IDisposable
    {
        /// <summary>
        /// Set the personal API key to be used for the authentication.
        /// </summary>
        /// <remarks>The API key can be created in the UniFi Site Manager &gt; API (https://unifi.ui.com/api)</remarks>
        /// <see href="https://unifi.ui.com/api">Site Manager &amp;gt; API</see>
        /// <param name="apiKey">Personal API key</param>
        void SetApiKey(string apiKey);

        /// <summary>
        /// Set the UserAgent to be used for the requests.
        /// </summary>
        /// <param name="userAgent">UserAgent name</param>
        void SetUserAgent(string userAgent);

        /// <summary>
        /// Retrieve a list of all hosts associated with the UI account making the API call.
        /// </summary>
        /// <remarks>
        /// The structure of userData and reportedState may vary depending on the UniFi OS or Network Server version. The example provided is based on UniFi OS 4.0.6.
        /// </remarks>
        Task<IEnumerable<IHost>> GetHosts();

        /// <summary>
        /// Retrieve a list of all hosts associated with the UI account making the API call.
        /// </summary>
        /// <remarks>
        /// The structure of userData and reportedState may vary depending on the UniFi OS or Network Server version. The example provided is based on UniFi OS 4.0.6.
        /// </remarks>
        /// <param name="cancellationToken">
        /// <see cref="CancellationToken"/> to cancel the request
        /// </param>
        Task<IEnumerable<IHost>> GetHosts(CancellationToken cancellationToken);

        /// <summary>
        /// Retrieves detailed information about a specific host by ID.
        /// </summary>
        /// <remarks>
        /// The structure of userData and reportedState may vary depending on the UniFi OS or Network Server version. The example provided is based on UniFi OS 4.0.6.
        /// </remarks>
        /// <param name="id">
        /// Host ID
        /// </param>
        Task<IHost> GetHostById(string id);

        /// <summary>
        /// Retrieves detailed information about a specific host by ID.
        /// </summary>
        /// <remarks>
        /// The structure of userData and reportedState may vary depending on the UniFi OS or Network Server version. The example provided is based on UniFi OS 4.0.6.
        /// </remarks>
        /// <param name="id">
        /// Host ID
        /// </param>
        /// <param name="cancellationToken">
        /// <see cref="CancellationToken"/> to cancel the request
        /// </param>
        Task<IHost> GetHostById(string id, CancellationToken cancellationToken);

        /// <summary>
        /// List sites.
        /// </summary>
        /// <remarks>
        /// The structure of userData and reportedState may vary depending on the UniFi OS or Network Server version. The example provided is based on UniFi OS 4.0.6.
        /// </remarks>
        Task<IEnumerable<ISite>> GetSites();

        /// <summary>
        /// List sites.
        /// </summary>
        /// <remarks>
        /// The structure of userData and reportedState may vary depending on the UniFi OS or Network Server version. The example provided is based on UniFi OS 4.0.6.
        /// </remarks>
        /// <param name="cancellationToken">
        /// <see cref="CancellationToken"/> to cancel the request
        /// </param>
        Task<IEnumerable<ISite>> GetSites(CancellationToken cancellationToken);

        /// <summary>
        /// List UniFi devices of owner.
        /// </summary>
        /// <remarks>
        /// The structure of userData and reportedState may vary depending on the UniFi OS or Network Server version. The example provided is based on UniFi OS 4.0.6.
        /// </remarks>
        /// <param name="hostIds">
        /// List of host IDs (optional) / default is NULL
        ///</param>
        /// <param name="time">
        /// Last processed timestamp of device (optional) / default is NULL
        ///</param>
        Task<IEnumerable<IHostDeviceInfo>> GetDevices(string[]? hostIds = null, DateTime? time = null);

        /// <summary>
        /// List UniFi devices of owner.
        /// </summary>
        /// <remarks>
        /// The structure of userData and reportedState may vary depending on the UniFi OS or Network Server version. The example provided is based on UniFi OS 4.0.6.
        /// </remarks>
        /// <param name="cancellationToken">
        /// <see cref="CancellationToken"/> to cancel the request
        /// </param>
        /// <param name="hostIds">
        /// List of host IDs (optional) / default is NULL
        ///</param>
        /// <param name="time">
        /// Last processed timestamp of device (optional) / default is NULL
        ///</param>
        Task<IEnumerable<IHostDeviceInfo>> GetDevices(CancellationToken cancellationToken, string[]? hostIds = null,
            DateTime? time = null);


        /// <summary>
        /// Get ISP metrics data for all sites linked to the UI account’s API
        /// </summary>
        /// <param name="metricType">Specify whether metrics are returned using 5m or 1h intervals.</param>
        /// <returns>List of Isp metrics</returns>
        Task<IEnumerable<IIspMetrics>> GetIspMetrics(IspMetricType metricType);

        /// <summary>
        /// Get ISP metrics data for all sites linked to the UI account’s API
        /// </summary>
        /// <param name="cancellationToken">
        /// <see cref="CancellationToken"/> to cancel the request
        /// </param>
        /// <param name="metricType">Specify whether metrics are returned using 5m or 1h intervals.</param>
        /// <returns>List of Isp metrics</returns>
        Task<IEnumerable<IIspMetrics>> GetIspMetrics(CancellationToken cancellationToken, IspMetricType metricType);

        /// <summary>
        /// Get ISP metrics data for all sites linked to the UI account’s API
        /// </summary>
        /// <param name="metricType">Specify whether metrics are returned using 5m or 1h intervals.</param>
        /// <param name="begin">The earliest timestamp to start retrieving data from.</param>
        /// <param name="end">The latest timestamp up to which data will be retrieved.</param>
        /// <returns>List of Isp metrics</returns>
        Task<IEnumerable<IIspMetrics>> GetIspMetrics(IspMetricType metricType, DateTime begin, DateTime end);

        /// <summary>
        /// Get ISP metrics data for all sites linked to the UI account’s API
        /// </summary>
        /// <param name="metricType">Specify whether metrics are returned using 5m or 1h intervals.</param>
        /// <param name="cancellationToken">
        /// <see cref="CancellationToken"/> to cancel the request
        /// </param>
        /// <param name="begin">The earliest timestamp to start retrieving data from.</param>
        /// <param name="end">The latest timestamp up to which data will be retrieved.</param>
        /// <returns>List of Isp metrics</returns>
        Task<IEnumerable<IIspMetrics>> GetIspMetrics(CancellationToken cancellationToken, IspMetricType metricType,
            DateTime begin,
            DateTime end);

        /// <summary>
        /// Get ISP metrics data for all sites linked to the UI account’s API
        /// </summary>
        /// <param name="metricType">Specify whether metrics are returned using 5m or 1h intervals.</param>
        /// <param name="duration">Specifies the time range of metrics to be retrieved, starting from when the request is made. Supports 24h for 5-minute metrics, and 7d or 30d for 1-hour metrics.</param>
        /// <returns>List of Isp metrics</returns>
        Task<IEnumerable<IIspMetrics>> GetIspMetrics(IspMetricType metricType, Duration duration);

        /// <summary>
        /// Get ISP metrics data for all sites linked to the UI account’s API
        /// </summary>
        /// <param name="cancellationToken">
        /// <see cref="CancellationToken"/> to cancel the request
        /// </param>
        /// <param name="metricType">Specify whether metrics are returned using 5m or 1h intervals.</param>
        /// <param name="duration">Specifies the time range of metrics to be retrieved, starting from when the request is made. Supports 24h for 5-minute metrics, and 7d or 30d for 1-hour metrics.</param>
        /// <returns>List of Isp metrics</returns>
        Task<IEnumerable<IIspMetrics>> GetIspMetrics(CancellationToken cancellationToken, IspMetricType metricType,
            Duration duration);

        /// <summary>
        /// Retrieve ISP metrics data based on specific query parameters. 5-minute metrics are available for at least 24 hours, and 1-hour metrics for at least 30 days.
        /// </summary>
        /// <param name="metricType">Specify whether metrics are returned using 5m or 1h intervals.</param>
        /// <param name="sites">Query data</param>
        /// <returns></returns>
        Task<IIspQueryMetrics> QueryIspMetrics(IspMetricType metricType, IEnumerable<QueryIspMetricsFilter> sites);

        /// <summary>
        /// Retrieve ISP metrics data based on specific query parameters. 5-minute metrics are available for at least 24 hours, and 1-hour metrics for at least 30 days.
        /// </summary>
        /// <param name="cancellationToken">
        /// <see cref="CancellationToken"/> to cancel the request
        /// </param>
        /// <param name="metricType">Specify whether metrics are returned using 5m or 1h intervals.</param>
        /// <param name="sites">Query data</param>
        /// <returns></returns>
        Task<IIspQueryMetrics> QueryIspMetrics(CancellationToken cancellationToken, IspMetricType metricType,
            IEnumerable<QueryIspMetricsFilter> sites);
    }
}
