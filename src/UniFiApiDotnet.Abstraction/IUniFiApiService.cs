using System;
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
        Task<IEnumerable<IHostDeviceInfo>> GetDevices(CancellationToken cancellationToken, string[]? hostIds = null, DateTime? time = null);
    }
}
