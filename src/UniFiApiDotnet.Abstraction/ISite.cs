using System;

namespace UniFiApiDotnet.Abstraction
{
    /// <summary>
    /// Site information
    /// </summary>
    public interface ISite
    {
        /// <summary>
        /// Id of the Host
        /// </summary>
        string HostId { get; set; }

        /// <summary>
        /// Indicates that the user (based on API token) is the owner of the Site
        /// </summary>
        bool IsOwner { get; set; }

        /// <summary>
        /// Meta information of the Site
        /// </summary>
        ISiteMeta Meta { get; set; }

        /// <summary>
        /// Permissions of the user (based on API token) for the Site
        /// </summary>
        string Permission { get; set; }

        /// <summary>
        /// Id of the Site
        /// </summary>
        string SiteId { get; set; }

        /// <summary>
        /// Statistics of the Site
        /// </summary>
        ISiteStatistics Statistics { get; set; }

        //todo: add documentation
        DateTime SubscriptionEndTime { get; set; }
    }
}